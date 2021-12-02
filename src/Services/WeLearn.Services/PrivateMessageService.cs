﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Services.Interfaces;
using WeLearn.Web.ViewModels.Message;
using WeLearn.Web.ViewModels.Message;

namespace WeLearn.Services
{
    public class PrivateMessageService : IPrivateMessageService
    {
        private readonly ApplicationDbContext context;

        public PrivateMessageService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public AllPrivateMessagesViewModel<PrivateMessageConversationViewModel> CreateConversationViewModel(string correspondent, string currentUserName, string currentUserId)
        {
            string sender = this.context.ApplicationUsers.FirstOrDefault(x => x.UserName == currentUserName)?.UserName;

            List<PrivateMessage> privateMessages = this.context.PrivateMessages
                .Include(x => x.Sender)
                .Include(x => x.Receiver)
                .Where(x =>
                    (x.SenderId == currentUserId && x.Receiver.UserName == correspondent) ||
                    (x.ReceiverId == currentUserId && x.Sender.UserName == correspondent))
                .OrderBy(x => x.CreatedOn)
                .ToList();

            var model = new AllPrivateMessagesViewModel<PrivateMessageConversationViewModel>()
            {
                PrivateMessageModels = new List<PrivateMessageConversationViewModel>(),
            };

            foreach (PrivateMessage privateMessage in privateMessages)
            {
                string otherCorrespondent = correspondent == currentUserName ? sender : correspondent;

                var privateMessageModel = new PrivateMessageConversationViewModel()
                {
                    Text = privateMessage.Text,
                    ReceiverId = privateMessage.ReceiverId,
                    ReceiverUsername = privateMessage.Receiver.UserName,
                    SenderUsername = privateMessage.Sender.UserName,
                    CurrentUsername = currentUserName,
                    ReplyTo = otherCorrespondent,
                    CreatedOn = privateMessage.CreatedOn,
                };

                model.PrivateMessageModels.Add(privateMessageModel);
            }

            return model;
        }

        public async Task CreatePrivateMessageAsync(PrivateMessageInputModel model, string currentUserId)
        {
            var privateMessage = new PrivateMessage
            {
                Text = model.Text,
                ReceiverId = this.context.ApplicationUsers.First(x => x.UserName == model.ReceiverUsername).Id,
                SenderId = currentUserId,
            };

            await this.context.PrivateMessages.AddAsync(privateMessage);
            await this.context.SaveChangesAsync();
        }

        public AllPrivateMessagesViewModel<PrivateMessageIndexViewModel> CreateIndexViewModel(string currentUsername, string currentUserId)
        {
            List<PrivateMessage> privateMessages = this.context.PrivateMessages
                            .Where(x => x.SenderId == currentUserId || x.ReceiverId == currentUserId)
                            .OrderByDescending(x => x.CreatedOn)
                            .ToList();

            var model = new AllPrivateMessagesViewModel<PrivateMessageIndexViewModel>()
            {
                PrivateMessageModels = new List<PrivateMessageIndexViewModel>(),
            };

            foreach (PrivateMessage privateMessage in privateMessages)
            {
                string receiver = this.context.ApplicationUsers.First(x => x.Id == privateMessage.ReceiverId).UserName;
                string sender = this.context.ApplicationUsers.First(x => x.Id == privateMessage.SenderId).UserName;
                string otherCorrespondent = receiver == currentUsername ? sender : receiver;
                bool isAlreadyPresent = model.PrivateMessageModels.Any(x => x.OtherCorrespondent == otherCorrespondent);

                if (!isAlreadyPresent)
                {
                    var privateMessageModel = new PrivateMessageIndexViewModel()
                    {
                        Text = privateMessage.Text,
                        OtherCorrespondent = otherCorrespondent,
                        CreatedOn = privateMessage.CreatedOn,
                    };

                    model.PrivateMessageModels.Add(privateMessageModel);
                }
            }

            return model;
        }
    }
}
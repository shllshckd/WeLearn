using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.LessonModule;
using WeLearn.Services.Interfaces;
using WeLearn.Services.Mapping;

namespace WeLearn.Services
{
    public class LikesService : ILikesService
    {
        private readonly IDeletableEntityRepository<Like> likesRepository;

        public LikesService(IDeletableEntityRepository<Like> likesRepository)
        {
            this.likesRepository = likesRepository;
        }

        public async Task<IEnumerable<T>> GetByUserId<T>(string userId)
            => await this.likesRepository
                .All()
                .Where(x => x.ApplicationUserId == userId)
                .To<T>()
                .ToListAsync();

        public int GetLikesCount(int lessonId)
            => this.likesRepository
                .All()
                .Count(x => x.LessonId == lessonId);

        public async Task ToggleLikeAsync(int lessonId, string userId)
        {
            var dbLike = this.likesRepository
                .All()
                .FirstOrDefault(x => x.LessonId == lessonId && x.ApplicationUserId == userId);

            // if the like doesn't already exist - user puts a like for the first time
            // else, the like exists and the user wants to remove it
            if (dbLike == null)
            {
                await this.AddLikeAsync(lessonId, userId);
            }
            else
            {
                this.RemoveLike(dbLike);
            }

            await this.likesRepository.SaveChangesAsync();
        }

        public async Task AddLikeAsync(int lessonId, string userId)
        {
            var like = new Like
            {
                LessonId = lessonId,
                ApplicationUserId = userId,
            };

            await this.likesRepository.AddAsync(like);
        }

        public void RemoveLike(Like like)
            => this.likesRepository.HardDelete(like);
    }
}
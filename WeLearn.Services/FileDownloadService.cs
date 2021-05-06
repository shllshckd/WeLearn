﻿using System.IO;
using System.Net;
using WeLearn.Services.Interfaces;
using WeLearn.Infrastructure.HelperModels;

namespace WeLearn.Services
{
    public class FileDownloadService : IFileDownloadService
    {
        public FileDownload DownloadFile(string link)
        {
            WebClient net = new WebClient();
            byte[] data = net.DownloadData(link);
            MemoryStream content = new MemoryStream(data);

            string contentType = "APPLICATION/octet-stream";
            string fileName = "download.zip";

            return new FileDownload { Content = content, ContentType = contentType, FileName = fileName };
        }
    }
}

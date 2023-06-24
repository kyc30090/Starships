using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public interface IImageService
    {
        Task<string> GetImage(string blobName, string containerName);
        Task<bool> DeleteImage(string blobName, string containerName);
        Task<string> CreateImage(string blobName, string containerName, IFormFile file);

    }
}
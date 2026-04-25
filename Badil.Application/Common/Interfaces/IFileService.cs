using Microsoft.AspNetCore.Http;

namespace Badil.Application.Common.Interfaces
{
    public interface IFileService
    {
        Task<string> UploadFileAsync(IFormFile file, string folderName);
        void DeleteFile(string filePath);
    }
}

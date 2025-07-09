using Microsoft.AspNetCore.Components.Forms;

namespace Brandgroup.BlazorExtensions.Bootstrap.Components;

public interface IFileSystemProvider {

    public Task<IEnumerable<FileManagerFile>> ListDirectoryAsync(string path);

    public Task CreateDirectory(string path);



    /// <summary>
    /// Deletes a file or directory at the specified path.
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public Task DeleteItemAsync(FileManagerFile file);



    /// <summary>
    /// 
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public Stream GetFileStream(FileManagerFile file);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="path">The relative path where the file should be located at, WITHOUT the file itself</param>
    /// <param name="file">A reference to the file object</param>
    public Task UploadFileAsync(string path, IBrowserFile file);
}
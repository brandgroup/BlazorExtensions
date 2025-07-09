using Microsoft.AspNetCore.Components.Forms;

namespace Brandgroup.BlazorExtensions.Bootstrap.Components;

public class DiskFileSystemProvider(string rootPath) : IFileSystemProvider {

    private string _rootPath = rootPath;



    /// <summary>
    /// 
    /// </summary>
    /// <param name="relativePath"></param>
    /// <returns></returns>
    public async Task<IEnumerable<FileManagerFile>> ListDirectoryAsync(string relativePath) {
        var absolutePath = Path.GetFullPath(Path.Combine(_rootPath, relativePath));

        var files = Directory.EnumerateFiles(absolutePath);
        var directories = Directory.EnumerateDirectories(absolutePath);

        var fmFiles = files.Select(x => new DiskFileManagerFile(x));
        var fmDirectories = directories.Select(x => new DiskFileManagerFile(x, FileManagerItemType.Folder));

        // Combine files and directories into a single list
        var fmItems = fmDirectories.Concat(fmFiles);

        return fmItems;

    }



    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Task CreateDirectory(string path) {
        throw new NotImplementedException();
    }



    /// <summary>
    /// 
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public async Task DeleteItemAsync(FileManagerFile file) {

        if (file is not DiskFileManagerFile diskFile) {
            throw new ArgumentException("File must be of type DiskFileManagerFile", nameof(file));
        }

        var absolutePath = Path.GetFullPath(Path.Combine(_rootPath, diskFile.FullPath));

        if (File.Exists(absolutePath)) {
            File.Delete(absolutePath);
        } else if (Directory.Exists(absolutePath)) {
            Directory.Delete(absolutePath, true);
        } else {
            // TODO: Throw the according exception if the item does not exist depending on the type
            throw new FileNotFoundException($"The item at '{absolutePath}' does not exist.");
        }
    }



    /// <summary>
    /// 
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public Stream GetFileStream(FileManagerFile file) {
        if (file is not DiskFileManagerFile diskFile) {
            throw new ArgumentException("File must be of type DiskFileManagerFile", nameof(file));
        }

        var stream = File.OpenRead(diskFile.FullPath);
        return stream;
    }



    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    /// <param name="file"></param>
    public async Task UploadFileAsync(string path, IBrowserFile file) {

        var absolutePath = Path.GetFullPath(Path.Combine(_rootPath, path));

        // Check if the directory exists, if not, throw an exception
        if (!Directory.Exists(absolutePath)) {
            throw new DirectoryNotFoundException($"The directory '{absolutePath}' does not exist.");
        }

        // Combine the file name with the path
        var filePath = Path.Combine(absolutePath, file.Name);

        // Save the file to the disk
        await using var stream = File.Create(filePath, 4096, FileOptions.Asynchronous | FileOptions.SequentialScan);
        await file.OpenReadStream().CopyToAsync(stream);
    }
}
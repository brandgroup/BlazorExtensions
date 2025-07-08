namespace Brandgroup.BlazorExtensions.Bootstrap.Components;

public class DiskFileSystemProvider(string rootPath) : IFileSystemProvider {

    private string _rootPath = rootPath;



    /// <summary>
    /// 
    /// </summary>
    /// <param name="relativePath"></param>
    /// <returns></returns>
    public async Task<IEnumerable<FileManagerFile>> ListDirectoryAsync(string relativePath)
    {
        var absolutePath = Path.GetFullPath(Path.Combine(_rootPath, relativePath));

        var files = Directory.EnumerateFiles(absolutePath);
        var directories = Directory.EnumerateDirectories(absolutePath);

        var fmFiles = files.Select(x => new DiskFileManagerFile(Path.GetFileName(x)) {FullPath = x});
        var fmDirectories = directories.Select(x => new DiskFileManagerFile(Path.GetFileName(x), FileManagerItemType.Folder) {FullPath = x});

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
    /// <param name="path"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Task DeleteDirectory(string path) {
        throw new NotImplementedException();
    }



    /// <summary>
    /// 
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public Stream GetFileStream(FileManagerFile file)
    {
        if (file is not DiskFileManagerFile diskFile)
        {
            throw new ArgumentException("File must be of type DiskFileManagerFile", nameof(file));
        }

        return File.OpenRead(diskFile.FullPath);
    }



    /// <summary>
    /// 
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="fileStream"></param>
    /// <exception cref="NotImplementedException"></exception>
    public void UploadFile(string filePath, Stream fileStream)
    {
        throw new NotImplementedException();
    }
}
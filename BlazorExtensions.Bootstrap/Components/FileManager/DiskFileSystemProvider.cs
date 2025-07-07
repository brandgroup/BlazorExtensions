namespace Brandgroup.BlazorExtensions.Bootstrap.Components;

public class DiskFileSystemProvider(string rootPath) : IFileSystemProvider {

    private string _rootPath = rootPath;


    public async Task<IEnumerable<FileManagerFile>> ListDirectoryAsync(string path)
    {

        var files = Directory.EnumerateFiles(Path.Combine(_rootPath));
        var directories = Directory.EnumerateDirectories(Path.Combine(_rootPath));

        var fmFiles = files.Select(x => new DiskFileManagerFile(Path.GetFileName(x)) {FullPath = x});
        var fmDirectories = directories.Select(x => new DiskFileManagerFile(Path.GetFileName(x), FileManagerItemType.Folder) {FullPath = x});

        // Combine files and directories into a single list
        var fmItems = fmDirectories.Concat(fmFiles);

        return fmItems;

    }

    public Task CreateDirectory(string path) {
        throw new NotImplementedException();
    }

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
}
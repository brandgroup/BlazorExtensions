namespace Brandgroup.BlazorExtensions.Bootstrap.Components;

public interface IFileSystemProvider {

    public Task<IEnumerable<FileManagerFile>> ListDirectoryAsync(string path);

    public Task CreateDirectory(string path);

    public Task DeleteDirectory(string path);

    public Stream GetFileStream(FileManagerFile file);

    public void UploadFile(string filePath, Stream fileStream);
}
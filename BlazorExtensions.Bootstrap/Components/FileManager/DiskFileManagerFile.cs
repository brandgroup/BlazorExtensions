using System.Diagnostics.CodeAnalysis;

namespace Brandgroup.BlazorExtensions.Bootstrap.Components;

public class DiskFileManagerFile : FileManagerFile {

    public required string FullPath { get; init; }

    [SetsRequiredMembers]
    public DiskFileManagerFile(string fullPath) : base(Path.GetFileName(fullPath)) {
        FullPath = fullPath;
    }

    [SetsRequiredMembers]
    public DiskFileManagerFile(string fullPath, FileManagerItemType type) : base(Path.GetFileName(fullPath), type) {
        FullPath = fullPath;
    }
}
using System.Diagnostics.CodeAnalysis;

namespace Brandgroup.BlazorExtensions.Bootstrap.Components;

public class DiskFileManagerFile : FileManagerFile {

    public string? FullPath { get; set; }

    [SetsRequiredMembers]
    public DiskFileManagerFile(string name) : base(name)
    {
    }

    [SetsRequiredMembers]
    public DiskFileManagerFile(string name, FileManagerItemType type) : base(name, type)
    {
    }
}
using System.Diagnostics.CodeAnalysis;

namespace Brandgroup.BlazorExtensions.Bootstrap.Components;

public abstract class FileManagerFile {

    public required string Name { get; set; }

    public required FileManagerItemType Type { get; set; }


    [SetsRequiredMembers]
    public FileManagerFile(string name) {
        Name = name;
        Type = GetItemTypeFromFileName(name);
    }



    [SetsRequiredMembers]
    public FileManagerFile(string name, FileManagerItemType type)
    {
        Name = name;
        Type = type;
    }


    public static FileManagerItemType GetItemTypeFromFileName(string fileName)
    {
        var extension = Path.GetExtension(fileName).ToLowerInvariant();

        return fileName switch
        {
            "pdf" => FileManagerItemType.Pdf,
            _ => FileManagerItemType.Unspecified
        };
    }

}
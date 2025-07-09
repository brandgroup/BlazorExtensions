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
    public FileManagerFile(string name, FileManagerItemType type) {
        Name = name;
        Type = type;
    }



    /// <summary>
    /// 
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    private static FileManagerItemType GetItemTypeFromFileName(string fileName) {
        var extension = Path.GetExtension(fileName).ToLowerInvariant();

        var result = extension switch {
            ".pdf" => FileManagerItemType.Pdf,
            ".xlsx" => FileManagerItemType.Excel,
            ".txt" => FileManagerItemType.Text,
            ".md" => FileManagerItemType.Richtext,
            ".html" => FileManagerItemType.Richtext,
            _ => FileManagerItemType.Unspecified
        };

        return result;
    }

}
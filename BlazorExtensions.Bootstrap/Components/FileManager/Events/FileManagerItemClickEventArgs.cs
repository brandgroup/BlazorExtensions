using System.Diagnostics.CodeAnalysis;
using Brandgroup.BlazorExtensions.Bootstrap.Components.FileManager;

namespace Brandgroup.BlazorExtensions.Bootstrap.Components;

public class FileManagerItemClickEventArgs : EventArgs {


    public required FileManagerItem Item { get; set; }




    [SetsRequiredMembers]
    public FileManagerItemClickEventArgs(FileManagerItem item) {
        Item = item;
    }
}
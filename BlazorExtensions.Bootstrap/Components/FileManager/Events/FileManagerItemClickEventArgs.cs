using System.Diagnostics.CodeAnalysis;
using Brandgroup.BlazorExtensions.Bootstrap.Components.FileManager;

namespace Brandgroup.BlazorExtensions.Bootstrap.Components;

public class FileManagerItemClickEventArgs : EventArgs {


    public required FileManagerItem Object { get; set; }




    [SetsRequiredMembers]
    public FileManagerItemClickEventArgs(FileManagerItem item) {
        Object = item;
    }
}
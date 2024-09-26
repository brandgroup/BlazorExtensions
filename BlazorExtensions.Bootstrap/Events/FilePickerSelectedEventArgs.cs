using Brandgroup.BlazorExtensions.Bootstrap.Components;

namespace Brandgroup.BlazorExtensions.Bootstrap.Events;



public class FilePickerSelectedEventArgs : EventArgs
{



    public IEnumerable<DirectoryFilePicker.BrowserFileWithPath> SelectedFiles { get; set; }



    /// <summary>
    /// 
    /// </summary>
    /// <param name="selectedFiles"></param>
    public FilePickerSelectedEventArgs(IEnumerable<DirectoryFilePicker.BrowserFileWithPath> selectedFiles)
    {
        SelectedFiles = selectedFiles;
    }
}
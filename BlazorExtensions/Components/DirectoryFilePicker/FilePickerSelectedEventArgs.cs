namespace Brandgroup.BlazorExtensions.Components;



public class FilePickerSelectedEventArgs : EventArgs {



    public IEnumerable<BrowserFileWithPath> SelectedFiles { get; set; }



    /// <summary>
    /// 
    /// </summary>
    /// <param name="selectedFiles"></param>
    public FilePickerSelectedEventArgs(IEnumerable<BrowserFileWithPath> selectedFiles) {
        SelectedFiles = selectedFiles;
    }
}
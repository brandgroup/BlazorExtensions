using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Brandgroup.BlazorExtensions.Components.Events;



public class FilePickerSelectedEventArgs : EventArgs {



    public IEnumerable<DirectoryFilePicker.BrowserFileWithPath> SelectedFiles { get; set; }



    /// <summary>
    /// 
    /// </summary>
    /// <param name="selectedFiles"></param>
    public FilePickerSelectedEventArgs(IEnumerable<DirectoryFilePicker.BrowserFileWithPath> selectedFiles) {
        SelectedFiles = selectedFiles;
    }
}
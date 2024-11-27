namespace Brandgroup.BlazorExtensions.Bootstrap.Components;



public class RecordSelectEventArgs(object record, bool selected) : RecordEventArgs(record) {



    public bool Selected { get; set; } = selected;
}
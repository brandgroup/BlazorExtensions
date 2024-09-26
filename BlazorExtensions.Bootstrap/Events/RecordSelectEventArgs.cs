namespace Brandgroup.BlazorExtensions.Bootstrap.Events;



public class RecordSelectEventArgs(object record, bool selected) : RecordEventArgs(record)
{



    public bool Selected { get; set; } = selected;
}
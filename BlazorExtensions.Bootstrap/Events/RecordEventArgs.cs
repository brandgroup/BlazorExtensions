namespace Brandgroup.BlazorExtensions.Bootstrap.Events;



/// <summary>
/// 
/// </summary>
/// <param name="record"></param>
public class RecordEventArgs(object record) : EventArgs
{



    public object Record { get; set; } = record;
}
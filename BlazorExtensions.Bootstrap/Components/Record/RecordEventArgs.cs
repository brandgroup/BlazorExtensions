namespace Brandgroup.BlazorExtensions.Bootstrap.Components;



/// <summary>
/// 
/// </summary>
/// <param name="record"></param>
public class RecordEventArgs(object record) : EventArgs {



    public object Record { get; set; } = record;
}
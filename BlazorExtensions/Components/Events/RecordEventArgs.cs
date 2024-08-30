using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brandgroup.BlazorExtensions.Components.Bootstrap;

namespace Brandgroup.BlazorExtensions.Components.Events;



/// <summary>
/// 
/// </summary>
/// <param name="record"></param>
public class RecordEventArgs(object record) : EventArgs {



    public object Record { get; set; } = record;
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Brandgroup.BlazorExtensions.Components.Events;



public class RecordSelectEventArgs(object record, bool selected) : RecordEventArgs(record) {



    public bool Selected { get; set; } = selected;
}
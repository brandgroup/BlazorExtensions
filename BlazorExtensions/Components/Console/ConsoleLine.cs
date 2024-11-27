using System.Reflection.Metadata;

namespace Brandgroup.BlazorExtensions.Components;



public class ConsoleLine {


    public IList<ConsoleTextPart> Parts { get; set; } = new List<ConsoleTextPart>();



    /// <summary>
    /// Constructs an empty ConsoleLine with no text parts.
    /// </summary>
    public ConsoleLine() {

    }


    /// <summary>
    /// Constructs a ConsoleLine with a single text part and no color set.
    /// </summary>
    /// <param name="text"></param>
    public ConsoleLine(string text) {
        Parts.Add(new ConsoleTextPart(text));
    }



    /// <summary>
    /// Constructs a ConsoleLine with a single colored text part.
    /// </summary>
    /// <param name="text"></param>
    /// <param name="color"></param>
    public ConsoleLine(string text, string color) {
        Parts.Add(new ConsoleTextPart(text, color));
    }
}
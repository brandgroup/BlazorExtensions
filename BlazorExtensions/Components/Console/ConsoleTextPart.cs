namespace Brandgroup.BlazorExtensions.Components;

public class ConsoleTextPart {

    public string Text { get; set; }

    public string? Color { get; set; }




    public ConsoleTextPart(string text, string color) {
        Text = text;
        Color = color;
    }


    public ConsoleTextPart(string text) {
        Text = text;
    }
}
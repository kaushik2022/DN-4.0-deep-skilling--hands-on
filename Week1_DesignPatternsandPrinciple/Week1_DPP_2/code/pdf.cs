using System;
public class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("PDF Document is opened.");
    }
}

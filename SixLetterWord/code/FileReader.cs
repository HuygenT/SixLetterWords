namespace SixLetterWord.code;

public class FileReader : IFileReader
{
    public string[] ReadWords(string filePath)
    {
        try
        {
            return File.ReadAllLines(filePath);
        }
        catch (FileNotFoundException ex)
        {
            // Console.WriteLine($"File not found: {ex.FileName}");
            Console.WriteLine("File");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }

        return new string[] { };
    }
}
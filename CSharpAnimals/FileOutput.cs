namespace CSharpAnimals;

public class FileOutput
{
    private string _fileName;

    public FileOutput(string fileName) => _fileName = fileName;

    public void WriteFile(string line)
    {
        try
        {
            using var sw = new StreamWriter(_fileName);
            sw.WriteLine($"{line}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Could not write to file {_fileName}: {e}");
        }
    }
}
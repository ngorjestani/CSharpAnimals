namespace CSharpAnimals;

public class FileInput
{
    private string _fileName;

    public FileInput(string fileName) => _fileName = fileName;

    public void ReadFile()
    {
        try
        {
            using var sr = new StreamReader(_fileName);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Could not read file {_fileName}: {e}");
        }
    }

    public string? ReadFileLine()
    {
        try
        {
            using (var sr = new StreamReader(_fileName))
            {
                return sr.ReadLine();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Could not read file {_fileName}: {e}");
            return null;
        }
    }
}
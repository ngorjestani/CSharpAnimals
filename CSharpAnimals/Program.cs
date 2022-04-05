using CSharpAnimals;

var OutFile = new FileOutput("animals.txt");
var InFile = new FileInput("animals.txt");

IList<ITalkable> zoo = new List<ITalkable>();

zoo.Add(new Dog(true, "Bean"));
zoo.Add(new Cat(9, "Charlie"));
zoo.Add(new Teacher(44, "Stacy Read"));

foreach (ITalkable thing in zoo)
{
    Console.WriteLine($"{thing.GetName()} says: {thing.Talk()}");
    OutFile.WriteFile($"{thing.GetName()} | {thing.Talk()}");
}
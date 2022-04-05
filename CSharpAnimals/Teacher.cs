namespace CSharpAnimals;

public class Teacher : Person, ITalkable
{
    public int Age { get; set; }
    
    public Teacher(int age, string name) : base(name) => Age = age;

    public string Talk() => "Don't forget to do the assigned reading";
    
    public string GetName() => Name;
}
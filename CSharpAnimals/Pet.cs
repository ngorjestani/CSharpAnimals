namespace CSharpAnimals;

public abstract class Pet
{
    protected string Name { get; }

    public Pet(string name) => Name = name;
}
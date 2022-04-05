namespace CSharpAnimals;

class Dog : Pet, ITalkable
{
    public bool IsFriendly { get; }
    
    public Dog(bool friendly, string name) : base(name) => IsFriendly = friendly;

    public string Talk() => "Bark";
    
    public string GetName() => Name;

    public override string ToString() => $"Dog: name={Name} friendly={IsFriendly}";
}
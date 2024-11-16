
Dog myDog = new Dog("Dawg");


Dog naabriDog = new Dog("Juss");


Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neigbours dogs name is {naabriDog.Name}.");

myDog.Rename("Tauno");

while (myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
}
myDog.WagTail();
class Dog
{
    private string _name;
    private int _levelOfHapiness;

    public Dog(string name)
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    public string Name
    { 
        get { return _name; }
    }
    public int LevelOfHapiness
    { 
        get { return _levelOfHapiness;  }
    }
    public void Rename(string newName)
    { 
        _name = newName;
        Console.WriteLine("Then dog has been renamed to: "+ newName);
    }

    public void Bark()
    {
        Console.WriteLine("auh- auh");
        _levelOfHapiness++;
    }

    public void WagTail()
    { 
        Console.WriteLine("Wiggle- wiggle");
    }

}

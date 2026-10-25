namespace BindingDemo;

// ---------------- Q5 ----------------
public class Person
{
    public int ID { get; set; }
    public string Name { get; set; } = "";
    public int Age { get; set; }

    public void Greet() => Console.WriteLine("I am a Person.");

    public virtual void Display() =>                                          // virtual
        Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}");
}

// ---------------- Q6 ----------------
public class Doctor : Person
{
    public string Specialty { get; set; } = "";

    public new void Greet() => Console.WriteLine("I am a Doctor.");          // Hiding

    public override void Display()                                            // Overriding
    {
        base.Display();
        Console.WriteLine($"Specialty: {Specialty}");
    }
}

public class Engineer : Person
{
    public string Field { get; set; } = "";
    public int YearsOfExperience { get; set; }

    public new void Greet() => Console.WriteLine("I am an Engineer.");       // Hiding

    public override void Display()                                            // Overriding
    {
        base.Display();
        Console.WriteLine($"Field: {Field}, Years of experience: {YearsOfExperience}");
    }
}

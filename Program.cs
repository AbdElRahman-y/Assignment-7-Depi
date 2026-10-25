namespace BindingDemo;

internal class Program
{
    // ---------------- Q7 ----------------
    static void ProcessPerson(Person person)
    {
        person.Greet();
        person.Display();
    }

    static void Main(string[] args)
    {
        // ================= Part 1 =================
        Console.WriteLine("---- Q3 ----");
        Shape shape = new Shape(2, 3);
        Console.WriteLine(shape.Area());          // 6

        Cube cube = new Cube(2, 3, 4);
        Console.WriteLine(cube.Area());
        cube.Print();

        Shape shapeRef = new Cube(2, 3, 4);
        Console.WriteLine(shapeRef.Area());

        Console.WriteLine("---- Q4 ----");
        object obj = new Cube(1, 2, 3);
        Console.WriteLine(obj.ToString());        // (Width = 1, Height = 2)  ← Shape.ToString

        // ================= Part 2 =================
        Console.WriteLine("---- Q7 ----");
        Person doctor = new Doctor
        {
            ID = 1, Name = "Ahmed", Age = 40, Specialty = "Cardiology"
        };
        Person engineer = new Engineer
        {
            ID = 2, Name = "Sara", Age = 30, Field = "Software", YearsOfExperience = 6
        };

        ProcessPerson(doctor);
        Console.WriteLine();
        ProcessPerson(engineer);

        // ================= Part 3 =================
        Console.WriteLine("---- Q12 ----");
        Car car = new Car();
        car.MoveForward();
        car.MoveBackward();

        Ship ship = new Ship();
        ship.MoveBackward();
        // Q14
        ((IMoveable)ship).MoveForward();
        IMoveable shipRef = ship;
        shipRef.MoveForward();

        Airplane airplane = new Airplane();
        airplane.MoveForward();
        airplane.MoveUp();

        IMoveable carRef = new Car();
        IMoveable planeRef = new Airplane();
        carRef.MoveForward();
        carRef.MoveBackward();
        planeRef.MoveForward();
        planeRef.MoveBackward();

        if (planeRef is IFlyable flyable)
            flyable.MoveUp();

        Console.WriteLine("---- Q13 ----");
        IVehicle vehicle = new Vehicle();
        vehicle.MoveForward();
        vehicle.MoveUp();
    }
}

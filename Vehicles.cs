namespace BindingDemo;

// ---------------- Q10 ----------------
public interface IMoveable
{
    void MoveForward();
    void MoveBackward();
}

public interface IFlyable
{
    void MoveUp();
    void MoveDown();
}

// ---------------- Q11 ----------------
public class Car : IMoveable
{
    public void MoveForward() => Console.WriteLine("Car moves forward on the ground.");
    public void MoveBackward() => Console.WriteLine("Car moves backward on the ground.");
}

// ---------------- Q14: Explicit Interface Implementation ----------------
public class Ship : IMoveable
{
    void IMoveable.MoveForward() => Console.WriteLine("Ship sails forward on the sea.");

    public void MoveBackward() => Console.WriteLine("Ship sails backward on the sea.");
}

public class Airplane : IMoveable, IFlyable
{
    public void MoveForward() => Console.WriteLine("Airplane flies forward in the air.");
    public void MoveBackward() => Console.WriteLine("Airplane flies backward in the air.");
    public void MoveUp() => Console.WriteLine("Airplane goes up.");
    public void MoveDown() => Console.WriteLine("Airplane goes down.");
}

// ---------------- Q13 ----------------
public interface IVehicle : IMoveable, IFlyable
{
}

public class Vehicle : IVehicle
{
    public virtual void MoveForward() => Console.WriteLine("Vehicle moves forward.");
    public virtual void MoveBackward() => Console.WriteLine("Vehicle moves backward.");
    public virtual void MoveUp() => Console.WriteLine("Vehicle moves up.");
    public virtual void MoveDown() => Console.WriteLine("Vehicle moves down.");
}

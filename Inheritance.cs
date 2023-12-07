/*using System; // Single Level Inheritance

public class Car
{
    public string model;
    public string color;
    public int price;

    public void PrintCarInformation()
    {
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Price: " + price);
    }
}
 class Maruti : Car
{
    float mileage;

    public void PrintMileage()
    {
        Console.WriteLine("Mileage: " + mileage);
    }

    public static void Main(string[] args)
    {
        Maruti myCar = new Maruti();
        myCar.model = "Swift";
        myCar.color = "white";
        myCar.price = 900000;
        myCar.mileage = 22.5f;
        myCar.PrintCarInformation();
        myCar.PrintMileage();
        Console.ReadLine();
    }
}

*/


// Multi Level Inheritance
/*using System;

public class Car
{
    public string model;
    public string color;
    public int price;

    public void PrintCarInformation()
    {
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Price: " + price);
    }
}
class Ferrari: Car
{
    public int speed;
    public void PrintSpeed() 
    {
        Console.WriteLine("Speed: " + speed);
    }
}
 class Maruti : Ferrari
{
    float mileage;

    public void PrintMileage()
    {
        Console.WriteLine("Mileage: " + mileage);
    }

    public static void Main(string[] args)
    {
        Maruti myCar = new Maruti();
        myCar.model = "Swift";
        myCar.color = "white";
        myCar.price = 900000;
        myCar.mileage = 22.5f;
        myCar.speed = 100;
        myCar.PrintCarInformation();
        myCar.PrintMileage();
        myCar.PrintSpeed();
        Console.ReadLine();
    }
}
*/

/*//Hierarchical inheritance:
using System;

public class Car//parent class
{
    public string model;
    public string color;
    public int price;

    public void PrintCarInformation()
    {
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Price: " + price);
    }
}
class Ferrari: Car//child class
{
    public int speed;
    public void PrintSpeed() 
    {
        Console.WriteLine("Speed: " + speed);
    }
}
 class Maruti : Car// child class
{
    float mileage;

    public void PrintMileage()
    {
        Console.WriteLine("Mileage: " + mileage);
    }

    public static void Main(string[] args)
    {
        Maruti myCar = new Maruti();
        myCar.model = "Swift";
        myCar.color = "white";
        myCar.price = 900000;
        myCar.mileage = 22.5f;
        myCar.PrintCarInformation();
        myCar.PrintMileage();
        Console.ReadLine();
    }
}*/
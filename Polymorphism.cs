/*using System;
public class OverLoading
{
    void Sum(int a, int b)  //Type of parameters
    {
        Console.WriteLine(a+b);
    }
    void Sum(float a, float b) 
    {
        Console.WriteLine(a+b);
    } 
    public static void Main(string[] args)
    {
        OverLoading obj = new OverLoading();
        //obj.Sum(10,20);
        obj.Sum(10.5f,20.5f);
        Console.ReadLine();
    }
}
*/

/*using System;
public class OverLoading
{
    void Sum(int a, int b) 
    {
        Console.WriteLine(a+b);
    }
    void Sum(int a, int b, int c) //Numbers of parameters
    {
        Console.WriteLine(a+b+c);
    }
    public static void Main(string[] args)
    {
        OverLoading obj = new OverLoading();
        obj.Sum(10,20,30);
        Console.ReadLine();
    }
}*/

/*using System;
public class OverLoading
{
    void Sum(int a, float b) 
    {
        Console.WriteLine(a+b);
    }
    void Sum(float a, int b) //sequence of parameters
    {
        Console.WriteLine(a-b);
    }
    public static void Main(string[] args)
    {
        OverLoading obj = new OverLoading();
        obj.Sum(10.5f,20);
        Console.ReadLine();
    }
}*/


/*//Method Overriding
using System;
 class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}
class Dog: Animal
{
    public void Eat()
    {
        Console.WriteLine("Dog is eating");
    }
    public static void Main(String[] args) 
    {
        Dog tommy = new Dog();
        tommy.Eat();
        Console.ReadLine();
    }
}*/
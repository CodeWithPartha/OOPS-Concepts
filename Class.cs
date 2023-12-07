using System;
 public class Calculator
    {
        int num1;
        int num2;
        int result;

        public void Add()
        {
            result = num1 + num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public void Mul()
        {
            result = num1 * num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        
        public static void Main(string[] args)
        {
            Calculator obj = new Calculator();
            obj.num1 = 2;
            obj.num2 = 3;
            obj.Add();
            obj.Mul();
        }
}
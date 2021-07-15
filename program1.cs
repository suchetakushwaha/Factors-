using System;
class Program1{
    public static void Main()
    {
        Console.WriteLine("Enter The Number");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Factor of "+ number +" are:" );
        
        for(int i = 1;i<=number;i++)
        {
           if(number % i == 0) 
           {
               Console.WriteLine(i + " ");
           }
        }
        Console.ReadLine();
    }
}




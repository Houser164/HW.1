
using System;

public class Program {

    public static void Main(string[] args) {
        string Name, Owner_name;
        double Number, Value,  x1000, x500, x100, x50, x20, x10,x5, x2, x1, x0_50, x0_25, XXX;
        
        Console.WriteLine("----------Shop Information----------");

        Console.WriteLine("Please input Name: ");
        Name = Console.ReadLine();

        Console.WriteLine("Please input Number: ");
        Number = double.Parse(Console.ReadLine());

        Console.WriteLine("Please input Owner name: ");
        Owner_name = Console.ReadLine();

        Console.WriteLine("Please input Registered Value: ");
        Value = double.Parse(Console.ReadLine());

        Console.WriteLine("----------------------------");
        
       
        Console.WriteLine("Please input money: ");
        string UUU= Console.ReadLine();


        XXX= Check_money(UUU);
        ABC (XXX); 
     }

       public static double []ABC(double XXX){
       double x1000, x500, x100, x50, x20, x10,x5, x2, x1, x0_50, x0_25;

        x1000 = XXX/1000;
        x500 = (XXX%1000)/500;
        x100 = ((XXX%1000)%500)/100;
        x50 = (((XXX%1000)%500)%100)/50;
        x20 = ((((XXX%1000)%500)%100)%50)/20;
        x10 = (((((XXX%1000)%500)%100)%50)%20)/10;
        x5 = ((((((XXX%1000)%500)%100)%50)%20)%10)/5;
        x2 = (((((((XXX%1000)%500)%100)%50)%20)%10)%5)/2;
        x1 = ((((((((XXX%1000)%500)%100)%50)%20)%10)%5)%2)/1;
        x0_50 = (((((((((XXX%1000)%500)%100)%50)%20)%10)%5)%2)%1)/(0.5);
        x0_25 = ((((((((((XXX%1000)%500)%100)%50)%20)%10)%5)%2)%1)%(0.5))/(0.25);
        
        Console.WriteLine("1000 : {0}",Math.Floor (x1000));
        Console.WriteLine("500 : {0}",Math.Floor (x500));
        Console.WriteLine("100 : {0}",Math.Floor (x100));
        Console.WriteLine("50 : {0}",Math.Floor (x50));
        Console.WriteLine("20 : {0}",Math.Floor (x20));
        Console.WriteLine("10 : {0}",Math.Floor (x10));
        Console.WriteLine("5 : {0}",Math.Floor (x5));
        Console.WriteLine("2 : {0}",Math.Floor (x2));
        Console.WriteLine("1 : {0}",Math.Floor (x1));
        Console.WriteLine("0.5 : {0}",Math.Floor (x0_50));
        Console.WriteLine("0.25 : {0}",Math.Floor (x0_25));
        double[]WWW= {Math.Floor (x1000), Math.Floor (x500), Math.Floor (x100), Math.Floor (x50), Math.Floor (x20), Math.Floor (x10), Math.Floor (x5), Math.Floor (x2), Math.Floor (x1), Math.Floor (x0_50), Math.Floor (x0_25)};

        return WWW;
        
       }
       
    
    public static double Check_money(string UUU) {

            if (double .TryParse(UUU, out double money)){
                return money;
                }
                throw new Exception(" !!! Please enter numerical amount !!! ");
                }
}


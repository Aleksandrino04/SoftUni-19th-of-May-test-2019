using System;

namespace _01._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int annualTax = int.Parse(Console.ReadLine());
            double shoesTax = annualTax-(annualTax * 40 / 100);
            double equipmentTax = shoesTax - (shoesTax * 20 / 100);
            double ballTax = equipmentTax * 1 / 4;
            double basketAcessories = ballTax * 1 / 5;

            double totalPrice = annualTax + shoesTax + equipmentTax + ballTax + basketAcessories;
            Console.WriteLine($"{totalPrice:f2}");



        }
    }
}

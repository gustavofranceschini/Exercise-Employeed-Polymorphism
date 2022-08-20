using System;
using System.Collections.Generic;
using Ex_Employeed.Entities;
using System.Globalization;

namespace Ex_Employeed
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            List<Employeed> list = new List<Employeed>();

            Console.Write("Enter the number employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employeed #{i} data:");
                Console.Write("Outsourced (y/n): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valeu per hours: R$ ");
                double valeuPerHour = double.Parse(Console.ReadLine(),CI);
                if (ch == 'y')
                {
                    Console.Write("Addition Charge: ");
                    double additionCharge = double.Parse(Console.ReadLine(), CI);
                    list.Add(new OutsourceEmployeed(name, hours, valeuPerHour, additionCharge));
                }else
                {
                    list.Add(new Employeed(name, hours, valeuPerHour));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employeed emp in list)
            {
                Console.WriteLine(emp.Name + " - $ "+emp.Payment().ToString("F2",CI));                
            }

        }
    }
}

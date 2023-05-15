using System;

class Program {
    static void Main(string[] args) {
        double b1;
        double b2;
        double b3;
        double payment;
        double Lefty = 0;

        Console.WriteLine("Enter the first miscellaneous amount (1):");
        b1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second miscellaneous amount (2):");
        b2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third miscellaneous amount (3):");
        b3 = double.Parse(Console.ReadLine());

        while (true) {
            Console.WriteLine("Enter a payment amount:");
            payment = double.Parse(Console.ReadLine());

            if (payment <= 0) {
                break;
            }

            if (b1 >= payment) {
                b1 -= payment;
            } else if (b2 >= payment) {
                b2 -= payment;
            } else if (b3 >= payment) {
                b3 -= payment;
            } else {
                Lefty += payment;
            }
        }

        Console.Write($"Balance 1: {b1}, ");
        Console.Write($"Balance 2: {b2}, ");
        Console.WriteLine($"Balance 3: {b3}");

        if (Lefty > 0) {
            Console.WriteLine($"Left: {Lefty}");
        }
    }
}
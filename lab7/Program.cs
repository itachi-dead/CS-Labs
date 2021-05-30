using System;
using System.Collections.Generic;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rational> rationalNumbers = new List<Rational>()
            {
                new Rational(6, 15),
                new Rational(1, 10),
                new Rational(9),

                (-8, 3),
                (1, 1),

                Rational.Parse("S", "1/2"),
                Rational.Parse("S", "13"),
                Rational.Parse("I", "10 1/3"),
                Rational.Parse("S", "-5/6"),
                Rational.Parse("D", "0.(3)"),
                Rational.Parse("S", "0/2"),
                Rational.Parse("D", "-0.08(3)"),
                Rational.Parse("D", "0.(142857)"),
                Rational.Parse("I", "-4 1/5"),
                Rational.Parse("D", "12.34(56)"),

                Rational.Parse("-0.(7)"),
                Rational.Parse("0.125"),
                Rational.Parse("-123/456"),
                Rational.Parse("0.1212(123)"),
                Rational.Parse("-1 2/3"),

                3,
                -15.0,
                6,
            };
            while (true)
            {
                Console.WriteLine("Enter:\n" +
                                  "1. Show list\n" +
                                  "2. Show the list in a specific format\n" +
                                  "3. Add to the list\n" +
                                  "4. Remove from list\n" +
                                  "5. Remove all numbers from list\n" +
                                  "6. Sort list\n" +
                                  "7. Add / subtract / multiply / divide\n" +
                                  "8. Сompare\n" +
                                  "9. Exit");
                Console.WriteLine();
                int action;
                while (!int.TryParse(Console.ReadLine(), out action) || action < 1 || action > 9)
                {
                    Console.WriteLine("Error! Try again");
                }
                Console.WriteLine();
                switch (action)
                {
                    case 1:
                        {
                            Console.WriteLine("Full list:");
                            for (int i = 0; i < rationalNumbers.Count; i++)
                            {
                                Console.WriteLine(string.Concat(i + 1, ". ", rationalNumbers[i]));
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter format:\n" +
                                              "\"s\" - m/n\n" +
                                              "\"S\" - m/n or n\n" +
                                              "\"i\" - a b/c\n" +
                                              "\"I\" - \"i\" or \"S\"\n" +
                                              "\"d\" - Non-periodic fraction\n" +
                                              "\"D\" - Periodic or non-periodic fraction\n" +
                                              "\"long\" - to long\n" +
                                              "\"decimal\" - to decimal");
                            string format = Console.ReadLine();
                            Console.WriteLine();
                            if (format == "s" || format == "S" || format == "i" ||
                                format == "I" || format == "d" || format == "D")
                            {
                                Console.WriteLine("Full list:");
                                for (int i = 0; i < rationalNumbers.Count; i++)
                                {
                                    Console.WriteLine(string.Concat(i + 1, ". ",
                                        rationalNumbers[i].ToString(format)));
                                }
                            }
                            else if (format == "long")
                            {
                                Console.WriteLine("Full list:");
                                for (int i = 0; i < rationalNumbers.Count; i++)
                                {
                                    Console.WriteLine(string.Concat(i + 1, ". ",
                                        (long)rationalNumbers[i]));
                                }
                            }
                            else if (format == "decimal")
                            {
                                Console.WriteLine("Full list:");
                                for (int i = 0; i < rationalNumbers.Count; i++)
                                {
                                    Console.WriteLine(string.Concat(i + 1, ". ",
                                        (decimal)rationalNumbers[i]));
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error!");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter a rational number in any format");
                            if (!Rational.TryParse(Console.ReadLine(), out Rational a))
                            {
                                Console.WriteLine("Error!");
                            }
                            else
                            {
                                rationalNumbers.Add(a);
                                Console.WriteLine("Successfully!");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter a rational number in any format");
                            if (!Rational.TryParse(Console.ReadLine(), out Rational a))
                            {
                                Console.WriteLine("Error!");
                            }
                            else if (rationalNumbers.Remove(a))
                            {
                                Console.WriteLine("Successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Not found");
                            }
                            break;
                        }
                    case 5:
                        {
                            rationalNumbers.Clear();
                            Console.WriteLine("Successfully!");
                            break;
                        }
                    case 6:
                        {
                            rationalNumbers.Sort();
                            Console.WriteLine("Successfully!");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Enter the first rational number in any format");
                            if (!Rational.TryParse(Console.ReadLine(), out Rational a))
                            {
                                Console.WriteLine("Error!");
                                continue;
                            }
                            Console.WriteLine("Enter the second rational number in any format");
                            if (!Rational.TryParse(Console.ReadLine(), out Rational b))
                            {
                                Console.WriteLine("Error!");
                                continue;
                            }
                            Console.WriteLine();
                            if (b > 0)
                            {
                                Console.WriteLine(string.Concat(a, " + ", b, " = ", a + b));
                                Console.WriteLine(string.Concat(a, " - ", b, " = ", a - b));
                                Console.WriteLine(string.Concat(a, " * ", b, " = ", a * b));
                                if (b == 0) Console.WriteLine("Division by zero is not allowed!");
                                else Console.WriteLine(string.Concat(a, " / ", b, " = ", a / b));
                            }
                            else
                            {
                                Console.WriteLine(string.Concat(a, " + (", b, ") = ", a + b));
                                Console.WriteLine(string.Concat(a, " - (", b, ") = ", a - b));
                                Console.WriteLine(string.Concat(a, " * (", b, ") = ", a * b));
                                if (b == 0) Console.WriteLine("Division by zero is not allowed!");
                                else Console.WriteLine(string.Concat(a, " / (", b, ") = ", a / b));
                            }
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Enter the first rational number in any format");
                            if (!Rational.TryParse(Console.ReadLine(), out Rational a))
                            {
                                Console.WriteLine("Error!");
                                continue;
                            }
                            Console.WriteLine("Enter the second rational number in any format");
                            if (!Rational.TryParse(Console.ReadLine(), out Rational b))
                            {
                                Console.WriteLine("Error!");
                                continue;
                            }
                            Console.WriteLine();
                            if (a > b)
                            {
                                Console.WriteLine(string.Concat(a, " > ", b));
                                Console.WriteLine(string.Concat(a.ToString("I"), " > ", b.ToString("I")));
                                Console.WriteLine(string.Concat(a.ToString("D"), " > ", b.ToString("D")));
                            }
                            else if (a < b)
                            {
                                Console.WriteLine(string.Concat(a, " < ", b));
                                Console.WriteLine(string.Concat(a.ToString("I"), " < ", b.ToString("I")));
                                Console.WriteLine(string.Concat(a.ToString("D"), " < ", b.ToString("D")));
                            }
                            else
                            {
                                Console.WriteLine(string.Concat(a, " = ", b));
                                Console.WriteLine(string.Concat(a.ToString("I"), " = ", b.ToString("I")));
                                Console.WriteLine(string.Concat(a.ToString("D"), " = ", b.ToString("D")));
                            }
                            break;
                        }
                    default:
                        {
                            return;
                        }
                }
                Console.WriteLine();
            }
        }
    }
}

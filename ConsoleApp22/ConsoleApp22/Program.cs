using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string u = Console.ReadLine();
            Console.WriteLine("TEsssttt");

            if (x >= 0 && x <= 999999)
            {


                if (u == "CIA")
                {

                    if (x % 10 != 3 && x % 10 != 6 && x % 10 != 9)
                    {
                        Console.WriteLine("!Password is incorrect 1");
                    }
                    else if (x % 100 >= 10 && x % 100 <= 19)
                    {
                        Console.WriteLine("!Password is incorrect 2");
                    }
                    else if (x % 100 >= 30 && x % 100 <= 39)
                    {
                        Console.WriteLine("!Password is incorrect 3");
                    }
                    else if (x % 100 >= 50 && x % 100 <= 59)
                    {
                        Console.WriteLine("!Password is incorrect 4");
                    }
                    else if (x % 10000 >= 0 && x % 10000 <= 5999)
                    {
                        Console.WriteLine("!Password is incorrect 5");
                    }
                    else if (x % 10000 >= 8000 && x % 10000 <= 8999)
                    {
                        Console.WriteLine("!Password is incorrect 6");
                    }
                    else
                    {
                        Console.WriteLine("-----Password is correct-----");
                    }
                }
                if (u == "FBI")
                {
                    if (x % 1000000 >= 100000 && x % 1000000 <= 399999 || x % 1000000 >= 800000 && x % 1000000 <= 999999)
                    {
                        Console.WriteLine("!Password is incorrect1");
                    }
                    else if (x % 1000 >= 100 && x % 1000 <= 199 || x % 1000 >= 300 && x % 1000 <= 399 || x % 1000 >= 500 && x % 1000 <= 599 || x % 1000 >= 700 && x % 1000 <= 799 || x % 1000 >= 900 && x % 1000 <= 999)
                    {
                        Console.WriteLine("!Password is incorrect2");
                    }
                    else if (x % 1000 >= 600 && x % 1000 <= 699)
                    {
                        Console.WriteLine("!Password is incorrect3");
                    }
                    else if ((x / 1000) % 2 == 0)
                    {
                        Console.WriteLine("!Password is incorrect4");
                    }
                    else
                    {
                        Console.WriteLine("-----Password is correct-----");
                    }
                }
                if (u == "NSA")
                {

                    if (x % 1000000 >= 700000 && x % 1000000 <= 799999)
                    {
                        if (x % 10 != 1 && x % 10 != 2 && x % 10 != 3 && x % 10 != 5 && x % 10 != 6)
                        {
                            Console.WriteLine("!Password is incorrect1");
                        }
                        else if (x % 1000 / 100 / 3 != 1 && x % 1000 / 100 / 3 != 3)
                        {
                            Console.WriteLine("!Password is incorrect2");
                        }
                        else
                        {
                            Console.WriteLine("-----Password is correct-----");
                        }
                    }
                    else if (x % 100000 >= 70000 && x % 100000 <= 79999)
                    {
                        if (x % 10 != 1 && x % 10 != 2 && x % 10 != 3 && x % 10 != 5 && x % 10 != 6)
                        {
                            Console.WriteLine("!Password is incorrect1");
                        }
                        else if (x % 1000 / 100 / 3 != 1 && x % 1000 / 100 / 3 != 3)
                        {
                            Console.WriteLine("!Password is incorrect2");
                        }
                        else
                        {
                            Console.WriteLine("-----Password is correct-----");
                        }
                    }
                    else if (x % 10000 >= 7000 && x % 10000 <= 7999) 
                    {
                        if (x % 10 != 1 && x % 10 != 2 && x % 10 != 3 && x % 10 != 5 && x % 10 != 6)
                        {
                            Console.WriteLine("!Password is incorrect1");
                        }
                        else if (x % 1000 / 100 / 3 != 1 && x % 1000 / 100 / 3 != 3)
                        {
                            Console.WriteLine("!Password is incorrect2");
                        }
                        else
                        {
                            Console.WriteLine("-----Password is correct-----");
                        }
                    }
                    else if (x % 1000 >= 700 && x % 1000 <=799)
                    {
                        if (x % 10 != 1 && x % 10 != 2 && x % 10 != 3 && x % 10 != 5 && x % 10 != 6)
                        {
                            Console.WriteLine("!Password is incorrect1");
                        }
                        else if (x % 1000 / 100 / 3 != 1 && x % 1000 / 100 / 3 != 3)
                        {
                            Console.WriteLine("!Password is incorrect2");
                        }
                        else
                        {
                            Console.WriteLine("-----Password is correct-----");
                        }
                    }
                    else if (x % 100 >= 70 && x % 100 <=79)
                    {
                        if (x % 10 != 1 && x % 10 != 2 && x % 10 != 3 && x % 10 != 5 && x % 10 != 6)
                        {
                            Console.WriteLine("!Password is incorrect1");
                        }
                        else if (x % 1000 / 100 / 3 != 1 && x % 1000 / 100 / 3 != 3)
                        {
                            Console.WriteLine("!Password is incorrect2");
                        }
                        else
                        {
                            Console.WriteLine("-----Password is correct-----");
                        }
                    }
                    else if (x % 10 == 7)
                    {
                        if (x % 10 != 1 && x % 10 != 2 && x % 10 != 3 && x % 10 != 5 && x % 10 != 6)
                        {
                            Console.WriteLine("!Password is incorrect1");
                        }
                        else if (x % 1000 / 100 / 3 != 1 && x % 1000 / 100 / 3 != 3)
                        {
                            Console.WriteLine("!Password is incorrect2");
                        }
                        else
                        {
                            Console.WriteLine("-----Password is correct-----");
                        }
                    }
                    else
                    {
                        Console.WriteLine("!Password is incorrect");
                    }
                }
                else
                {
                    Console.WriteLine("!Password is incorrect");
                }
            }
            else
            {
                Console.WriteLine("!Password is incorrect");
            }

        }
    }
}
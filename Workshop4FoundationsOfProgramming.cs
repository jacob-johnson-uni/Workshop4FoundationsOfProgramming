using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;

namespace LabWeek4
{
    class program
    {
        static void Main()
        {
            Console.Write("Enter a task to run from the Workshop: ");
            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:
                    task1();
                    break;
                
                case 2:
                    task2();
                    break;

                case 3:
                    task3();
                    break;

                case 4:
                    task4();
                    break;
                
                case 5:
                    task5();
                    break;
                
                case 6:
                    task6();
                    break;
                case 7:
                    task7();
                    break;
                case 8:
                    task8();
                    break;
            }
        }

        static void task1()
        {
            Console.Write("Enter a whole number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = num % 2;

            if (result != 0)
            {
                Console.WriteLine($"{num} is odd.");
            }
            else
            {
                Console.WriteLine($"{num} is even.");
            }
        }

        static void task2()
        {
            Console.Write("Enter the temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp < 10)
            {
                Console.WriteLine("Too Cold!");
            }
            else if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("Comfortable");
            }
            else
            {
                Console.WriteLine("Too Hot!");
            }
        }

        static void task3()
        {
            bool discount = false;
            bool student = false;
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Are you a student? (true/false): ");
            string studentStr = Console.ReadLine();
            if(studentStr == "true")
            {
                student = true;
            }

            if (age < 18 || age > 65)
            {
                discount = true;
            }
            else if (student == true)
            {
                discount = true;
            }
            else
            {
                discount = false;
            }

            if (discount)
            {
                Console.WriteLine("Discount applies");
            }
            else
            {
                Console.WriteLine("Standard Ticket");
            }
        }
        static void task4()
        {
            Console.Write("Enter score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            if(score > 100)
            {
                task4();
            }

            string resultReturn = score >= 40 ? "Pass" : "Fail";

            Console.WriteLine($"Score: {resultReturn}");
        }

        static void task5()
        {
            Console.Write(" 1. Tea\n 2. Coffee\n 3. Hot Chocolate\n 4. Exit\n Choose an option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            string strOption;

            switch (option)
            {
                case 1:
                    strOption = "Tea"; 
                    break;
                case 2:
                    strOption = "Coffee";
                    break;
                case 3:
                    strOption = "Hot Chocolate";
                    break;
                case 4:
                    strOption = "Exit";
                    break;
                default:
                    strOption = "no option";
                    break;
            }
            Console.WriteLine($"You selected {strOption}");
        }

        static void task6()
        {
            Console.WriteLine("Quantity \t Total Price");
            for (int quantity = 10; quantity <= 100; quantity += 10)
            {
                decimal pricePerWidget;

                if(quantity < 50)
                {
                    pricePerWidget = 5.0m;
                }
                else if(quantity < 80)
                {
                    pricePerWidget = 4.0m;
                }
                else
                {
                    pricePerWidget = 2.5m;
                }

                decimal totalPrice = pricePerWidget * quantity;

                Console.WriteLine($"{quantity}\t\tGBP {totalPrice:F2}");
            }
        }

        static void task7()
        {
            bool repeat = false;
            do
            {
                Console.Write("Widget Quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                decimal pricePerWidget;

                if (quantity < 50)
                {
                    pricePerWidget = 5.0m;
                }
                else if (quantity < 80)
                {
                    pricePerWidget = 4.0m;
                }
                else
                {
                    pricePerWidget = 2.5m;
                }

                decimal totalPrice = pricePerWidget * quantity;

                Console.WriteLine($"Total Price: GBP {totalPrice:F2}");
                Console.Write("Another Quote? (y to continue, q to quit): ");
                string strRepeat = Console.ReadLine();
                if(strRepeat == "y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }

            } while (repeat = true);
        }

        static void task8()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            string clean = string.Concat(str.Where(c => !char.IsWhiteSpace);

            Console.WriteLine($"There are {clean.Count()} non-space characters.");
        }
    }
}

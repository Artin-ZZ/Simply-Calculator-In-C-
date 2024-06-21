using Helpers;

namespace Calculator
{
    class Calc
    {
        static void Main(string[] args)
        {
            try
            {
                // Main Loop
                while (true)
                {
                    string menu = "********************************\n";
                    menu += "**| 1.Add Functionality      |**\n";
                    menu += "**| 2.Subtract Functionality |**\n";
                    menu += "**| 3.Multiply Functionality |**\n";
                    menu += "**| 4.Devide Functionality   |**\n";
                    menu += "**| 5.Quit App               |**\n";
                    menu += "********************************\n\n";
                    menu += "Choose An Option:";
                    Console.WriteLine(menu);

                    // User Prombt
                    double user_prombt = Convert.ToDouble(Console.ReadLine());



                    // Check For Null Or Empty User Input
                    // If Empty Was Entered:
                    if (string.IsNullOrEmpty(Convert.ToString(user_prombt)) && string.IsNullOrWhiteSpace(Convert.ToString(user_prombt)))
                    {
                        throw new Exception("Please choose an option which is not null or empty!");
                    }
                    // If User Prombt Wasn't Empty:
                    else if (!string.IsNullOrEmpty(Convert.ToString(user_prombt)) && !string.IsNullOrWhiteSpace(Convert.ToString(user_prombt)))
                    {
                        // Adder
                        if (user_prombt == 1)
                        {
                            Console.WriteLine("Enter Number A:");
                            double numA = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter Number B:");
                            double numB = Convert.ToDouble(Console.ReadLine());

                            double result = CalcFuncs.Adder(numA, numB);
                            Console.WriteLine($"Adder result is: {result}");

                        }
                        // Subtractor
                        else if (user_prombt == 2)
                        {
                            Console.WriteLine("Enter Number A:");
                            double numA = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter Number B:");
                            double numB = Convert.ToDouble(Console.ReadLine());

                            double result = CalcFuncs.Subtractor(numA, numB);
                            Console.WriteLine($"Subtractor result is: {result}");
                        }
                        // Multiplier
                        else if (user_prombt == 3)
                        {
                            Console.WriteLine("Enter Number A:");
                            double numA = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter Number B:");
                            double numB = Convert.ToDouble(Console.ReadLine());

                            double result = CalcFuncs.Multiply(numA, numB);
                            Console.WriteLine($"Multiplier result is: {result}");
                        }
                        // Devider
                        else if (user_prombt == 4)
                        {
                            Console.WriteLine("Enter Number A:");
                            double numA = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter Number B:");
                            double numB = Convert.ToDouble(Console.ReadLine());

                            double result = CalcFuncs.Divide(numA, numB);
                            Console.WriteLine($"Divider result is: {result}");
                        }

                        else if (user_prombt == 5)
                        {
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Choose a valid menu option!");
                            continue;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
using System.Diagnostics;

{

    char exit;

    bool leave = false;

        while (leave != true)

        {
            Console.WriteLine("----------------------------");
            byte selection;

            double number1, number2, result;

            Console.WriteLine("1.Plus");

            Console.WriteLine("2.Minus");

            Console.WriteLine("3.Multiplication");

            Console.WriteLine("4.Division");

            Console.WriteLine("----------------------------");

            Console.Write("Select Transaction Type :");

            selection = Convert.ToByte(Console.ReadLine());


            Console.WriteLine("Incorrect Statement");

            if (selection == 1)

            {

                Console.Clear();

                Console.WriteLine("************************************");

                Console.WriteLine("****Selected action****");

                Console.WriteLine("************************************");

                Console.Write("1.Enter the Number:");

                number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("2.Enter the Number:");

                number2 = Convert.ToDouble(Console.ReadLine());

                result = number1 + number2;

                Console.WriteLine("Result = {0}", result);

            }

            else if (selection == 2)
            {
                Console.Clear();

                Console.WriteLine("************************************");

                Console.WriteLine("****Selected Process Subtraction Process****");

                Console.WriteLine("************************************");

                Console.Write("1.Enter the Number:");

                number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("2.Enter the Number:");

                number2 = Convert.ToDouble(Console.ReadLine());

                result = number1 - number2;

                Console.Write("Result = {0}", result);
            }

            else if (selection == 3)
            {

                Console.Clear();

                Console.WriteLine("***********************************");

                Console.WriteLine("****Selected Operation Multiplication Operation****");

                Console.WriteLine("***********************************");

                Console.Write("1.Enter the Number:");

                number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("2.Enter the Number:");

                number2 = Convert.ToDouble(Console.ReadLine());

                result = number1 * number2;

                Console.Write("Result = {0}", result);
            }

            else if (selection == 4)
            {
                Console.Clear();

                Console.WriteLine("**********************************");

                Console.WriteLine("****Selected Transaction Dividing Transaction****");

                Console.WriteLine("**********************************");

                Console.Write("1.Enter the Number:");

                number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("2.Enter the Number:");

                number2 = Convert.ToDouble(Console.ReadLine());

                if (number2 != 0)

                {

                    result = number1 / number2;

                    Console.Write("Result = {0}", result);

                }
                else
                    Console.WriteLine("!!!Divide by Zero Error!!!");
            }
            Console.Write("\n\nDo You Want to Quit? (E)");
            Console.WriteLine("Do You Want to Start Over? (H)");

            exit = Convert.ToChar(Console.ReadLine());

            if (exit == 'e' || exit == 'E')
            {
                leave = true; return;
            }

            else
            {
                leave = false;
            }
        }
    }
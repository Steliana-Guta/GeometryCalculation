using System;

namespace GeometryCalculation
{
    public class MainClass
    {

        public static void Main(string[] args)
        {

            {
                char userChoice;
                do
                {
                    Console.Clear();

                    Menu();
                    Console.WriteLine();

                    userChoice = ReadChar("Choose an option : ");
                    Console.Clear();

                    switch (userChoice)
                    {
                        case 'v':
                            Console.WriteLine("You chose the Volume problem.");
                            Volume();
                            break;
                        case 'p':
                            Console.WriteLine("You chose the Pythegorian theorem problem.");
                            Pythegorian();
                            break;
                        case 'x':
                            Exit();
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("Wrong choice.Please try again.");
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return to the Menu.");
                    Console.ReadKey();

                } while (userChoice != 'x');
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }

        }

        public static char ReadChar(string message)
        {
            Console.WriteLine(message);
            return Console.ReadKey().KeyChar;
        }
        public static void Menu()
        {
            Console.WriteLine("V. Volume of a box .");
            Console.WriteLine("P. Pythegorean theorem for a triangle.");
            Console.WriteLine("X. Exit.");
            Console.WriteLine("");


        }
        /// <summary>
        /// volume of a box problem 
        /// </summary>
        private static void Volume()
        {
            Console.WriteLine("Please insert the height of the box.");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert the width of the box.");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert the lenght of the box.");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int total = height * width * lenght;
            Console.WriteLine("The volume of your box is " + total);
        }
        /// <summary>
        /// pythegorian problem
        /// </summary>
        public static void Pythegorian()
        {
            Console.WriteLine("Im going to check if your triangle is right-angled.");
            Console.WriteLine("What is the first side length?");
            int length1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the second side length?");
            int length2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the third side length?");
            int length3 = Convert.ToInt32(Console.ReadLine());

            double hypotenuse = Math.Pow(length3, 2);

            Console.WriteLine("The square length of the hypotenuse is " + hypotenuse);

            double sides = Math.Pow(length1, 2) + Math.Pow(length2, 2);

            Console.WriteLine("And the square length of the other 2 sides together is " + sides);

            if (hypotenuse == sides)
            {
                Console.WriteLine("Because the Pythagorean theorem is true, this triangle is a right-angle triangle. ");

            }
            else
            {
                Console.WriteLine("The hypotenuse isn't equal to the sides , the Pythagorean theorem is not true, so this triangle is not a right-angle triangle.");

            }
        }
/// <summary>
/// exit method
/// </summary>
        public static void Exit()
        {
            Console.WriteLine("Bye-Bye!");
            Console.WriteLine();
        }



    }
}



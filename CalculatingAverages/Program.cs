using System;
using System.Linq;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks.Dataflow;

namespace CalculatingAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            sumOfNumbers();
            averageTenScores();
            averageASpecificNumberOfScores();
            averageaNonSpecificNumberOfScores();
            Console.ReadLine();
        }
        private static void sumOfNumbers()
        {
            //This will simply report the sum of ten numbers
            Console.WriteLine("Let me tell you the sum of ten numbers");

            start1:
            Console.WriteLine("Please enter your first number between 0 - 100");
            double inp1 = double.Parse(Console.ReadLine());
            if (inp1 >= 0 && inp1 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start1;
            }

            start2:
            Console.WriteLine("Please enter your second number between 0 - 100");
            double inp2 = double.Parse(Console.ReadLine());
            if (inp2 >= 0 && inp2 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start2;
            }

            start3:
            Console.WriteLine("Please enter your third number between 0 - 100");
            double inp3 = double.Parse(Console.ReadLine());
            if (inp3 >= 0 && inp3 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start3;
            }

            start4:
            Console.WriteLine("Please enter your fourth number between 0 - 100");
            double inp4 = double.Parse(Console.ReadLine());
            if (inp4 >= 0 && inp4 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start4;
            }

            start5:
            Console.WriteLine("Please enter your fifth number between 0 - 100");
            double inp5 = double.Parse(Console.ReadLine());
            if (inp5 >= 0 && inp5 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start5;
            }

            start6:
            Console.WriteLine("Please enter your sixth number between 0 - 100");
            double inp6 = double.Parse(Console.ReadLine());
            if (inp6 >= 0 && inp6 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start6;
            }

            start7:
            Console.WriteLine("Please enter your seventh number between 0 - 100");
            double inp7 = double.Parse(Console.ReadLine());
            if (inp7 >= 0 && inp7 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start7;
            }

            start8:
            Console.WriteLine("Please enter your eigth number between 0 - 100");
            double inp8 = double.Parse(Console.ReadLine());
            if (inp8 >= 0 && inp8 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start8;
            }

            start9:
            Console.WriteLine("Please enter your ninth number between 0 - 100");
            double inp9 = double.Parse(Console.ReadLine());
            if (inp9 >= 0 && inp9 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start9;
            }

            start10:
            Console.WriteLine("Please enter tenth number between 0 - 100");
            double inp10 = double.Parse(Console.ReadLine());
            if (inp10 >= 0 && inp10 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start10;
            }

            double answer = inp1 + inp2 + inp3 + inp4 + inp5 + inp6 + inp7 + inp8 + inp9 + inp10;

            Console.WriteLine($"Here is the sum of the numbers: \n {answer} ");

            Console.ReadLine();

        }
        private static void averageTenScores()
        {
            Console.WriteLine("\n \nLet me tell you the average score and average grade of ten students");

            start1:
            Console.WriteLine("Please enter your first number between 0 - 100");
            double inp1 = double.Parse(Console.ReadLine());
            if (inp1 >= 0 && inp1 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start1;
            }

            start2:
            Console.WriteLine("Please enter your second number between 0 - 100");
            double inp2 = double.Parse(Console.ReadLine());
            if (inp2 >= 0 && inp2 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start2;
            }

            start3:
            Console.WriteLine("Please enter your third number between 0 - 100");
            double inp3 = double.Parse(Console.ReadLine());
            if (inp3 >= 0 && inp3 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start3;
            }

            start4:
            Console.WriteLine("Please enter your fourth number between 0 - 100");
            double inp4 = double.Parse(Console.ReadLine());
            if (inp4 >= 0 && inp4 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start4;
            }

            start5:
            Console.WriteLine("Please enter your fifth number between 0 - 100");
            double inp5 = double.Parse(Console.ReadLine());
            if (inp5 >= 0 && inp5 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start5;
            }

            start6:
            Console.WriteLine("Please enter your sixth number between 0 - 100");
            double inp6 = double.Parse(Console.ReadLine());
            if (inp6 >= 0 && inp6 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start6;
            }

            start7:
            Console.WriteLine("Please enter your seventh number between 0 - 100");
            double inp7 = double.Parse(Console.ReadLine());
            if (inp7 >= 0 && inp7 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start7;
            }

            start8:
            Console.WriteLine("Please enter your eigth number between 0 - 100");
            double inp8 = double.Parse(Console.ReadLine());
            if (inp8 >= 0 && inp8 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start8;
            }

            start9:
            Console.WriteLine("Please enter your ninth number between 0 - 100");
            double inp9 = double.Parse(Console.ReadLine());
            if (inp9 >= 0 && inp9 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start9;
            }

            start10:
            Console.WriteLine("Please enter tenth number between 0 - 100");
            double inp10 = double.Parse(Console.ReadLine());
            if (inp10 >= 0 && inp10 <= 100)
            {
            }
            else
            {
                Console.WriteLine("The number you entered is not between 0 - 100");
                goto start10;
            }

            double preanswer = inp1 + inp2 + inp3 + inp4 + inp5 + inp6 + inp7 + inp8 + inp9 + inp10;
            double avg = preanswer / 10;

            Console.WriteLine($"This is the average numerical grade: \n {avg}");

            if (avg >= 97 && avg <= 100)
            {
                Console.WriteLine("This is your grade average: \n A+");
            }
            else if (avg >= 94 && avg <= 96)
            {
                Console.WriteLine("This is your grade average: \n A");
            }
            else if (avg >= 90 && avg <= 93)
            {
                Console.WriteLine("This is your grade average: \n A-");
            }
            else if (avg >= 87 && avg <= 89)
            {
                Console.WriteLine("This is your grade average: \n B+");
            }
            else if (avg >= 84 && avg <= 86)
            {
                Console.WriteLine("This is your grade average: \n B");
            }
            else if (avg >= 80 && avg <= 83)
            {
                Console.WriteLine("This is your grade average: \n B-");
            }
            else if (avg >= 77 && avg <= 79)
            {
                Console.WriteLine("This is your grade average: \n C+");
            }
            else if (avg >= 74 && avg <= 76)
            {
                Console.WriteLine("This is your grade average: \n C");
            }
            else if (avg >= 70 && avg <= 73)
            {
                Console.WriteLine("This is your grade average: \n C-");
            }
            else if (avg >= 68 && avg <= 69)
            {
                Console.WriteLine("This is your grade average: \n D+");
            }
            else if (avg >= 66 && avg <= 67)
            {
                Console.WriteLine("This is your grade average: \n D");
            }
            else if (avg >= 60 && avg <= 65)
            {
                Console.WriteLine("This is your grade average: \n D-");
            }
            else if (avg <= 59)
            {
                Console.WriteLine("This is your grade average: \n F");
            }
            else
            {
            };

        }
        private static void averageASpecificNumberOfScores()
        {
            Console.WriteLine("\n \nLet me help you figure out your average score and average grade");

            Console.WriteLine("Please enter how many scores you have");
            double amountOf = double.Parse(Console.ReadLine());

            double[] a = new double[(int)amountOf];

            Console.Write("\n\nNow enter your scores\n");
            Console.Write("--------------------------\n");

            for (int i = 0; i < amountOf; i++)
            {
                Console.Write("Please enter a score : ", i);
                a[i] = double.Parse((Console.ReadLine()));  //im changing shit here
            }

            double sum = a.Sum();

            Console.Write("\n\n");

            double avg = sum / amountOf;

            Console.WriteLine($"This is the average numerical grade: \n {avg}");

            if (avg >= 97 && avg <= 100)
            {
                Console.WriteLine("This is your grade average: \n A+");
            }
            else if (avg >= 94 && avg <= 96)
            {
                Console.WriteLine("This is your grade average: \n A");
            }
            else if (avg >= 90 && avg <= 93)
            {
                Console.WriteLine("This is your grade average: \n A-");
            }
            else if (avg >= 87 && avg <= 89)
            {
                Console.WriteLine("This is your grade average: \n B+");
            }
            else if (avg >= 84 && avg <= 86)
            {
                Console.WriteLine("This is your grade average: \n B");
            }
            else if (avg >= 80 && avg <= 83)
            {
                Console.WriteLine("This is your grade average: \n B-");
            }
            else if (avg >= 77 && avg <= 79)
            {
                Console.WriteLine("This is your grade average: \n C+");
            }
            else if (avg >= 74 && avg <= 76)
            {
                Console.WriteLine("This is your grade average: \n C");
            }
            else if (avg >= 70 && avg <= 73)
            {
                Console.WriteLine("This is your grade average: \n C-");
            }
            else if (avg >= 68 && avg <= 69)
            {
                Console.WriteLine("This is your grade average: \n D+");
            }
            else if (avg >= 66 && avg <= 67)
            {
                Console.WriteLine("This is your grade average: \n D");
            }
            else if (avg >= 60 && avg <= 65)
            {
                Console.WriteLine("This is your grade average: \n D-");
            }
            else if (avg <= 59)
            {
                Console.WriteLine("This is your grade average: \n F");
            }
            else
            {
            };
        }
        private static void averageaNonSpecificNumberOfScores()
        {
            Console.WriteLine("\n \nLet me help you figure out your average score and average grade");

            decimal[] a = new decimal[400];
            string[] b = new string[400];

            Console.Write("\n\nNow enter your scores \n");
            Console.Write("-------------------------=\n");

            for (int i = 0; i < 400; i++)
            {
                Console.WriteLine("Please enter a score : ", i);
                b[i] = Convert.ToString(Console.ReadLine());

                a[i] = decimal.Parse(b[i]);

                Console.WriteLine("Are you done Y/N?");
                char wassup = char.Parse(Console.ReadLine());

                if (wassup == 'y' || wassup == 'Y')
                {
                    goto carryon;
                }
                else if (wassup == 'n' || wassup == 'N')
                {
                }
            }
        carryon:
            int size = a.Count(n => n == 0);
            int sizeOf = 400 - size;

            decimal sum = a.Sum();
            decimal avg = sum / sizeOf;

            Console.Write("\n\n");
            
            Console.WriteLine($"This is the average numerical grade: \n {avg}");

            if (avg >= 97 && avg <= 100)
            {
                Console.WriteLine("This is your grade average: \n A+");
            }
            else if (avg >= 94 && avg <= 96)
            {
                Console.WriteLine("This is your grade average: \n A");
            }
            else if (avg >= 90 && avg <= 93)
            {
                Console.WriteLine("This is your grade average: \n A-");
            }
            else if (avg >= 87 && avg <= 89)
            {
                Console.WriteLine("This is your grade average: \n B+");
            }
            else if (avg >= 84 && avg <= 86)
            {
                Console.WriteLine("This is your grade average: \n B");
            }
            else if (avg >= 80 && avg <= 83)
            {
                Console.WriteLine("This is your grade average: \n B-");
            }
            else if (avg >= 77 && avg <= 79)
            {
                Console.WriteLine("This is your grade average: \n C+");
            }
            else if (avg >= 74 && avg <= 76)
            {
                Console.WriteLine("This is your grade average: \n C");
            }
            else if (avg >= 70 && avg <= 73)
            {
                Console.WriteLine("This is your grade average: \n C-");
            }
            else if (avg >= 68 && avg <= 69)
            {
                Console.WriteLine("This is your grade average: \n D+");
            }
            else if (avg >= 66 && avg <= 67)
            {
                Console.WriteLine("This is your grade average: \n D");
            }
            else if (avg >= 60 && avg <= 65)
            {
                Console.WriteLine("This is your grade average: \n D-");
            }
            else if (avg <= 59)
            {
                Console.WriteLine("This is your grade average: \n F");
            }
            else
            {
            };

        }
    }
}

using System;
using System.Text;
namespace Arrayer

{
    class Program
    {
        static void Main(string[] args)
        {
            MovePosition();
            //Sevenb();
            //Paint4();
            //BubbleSort();
            //Paint3();
            // GetAverage();
            // WriteContentOfArray();
            //AddAndSubstract();
            //WriteOddNumbers();
        }
        static public void MovePosition()
        {
           // Console.Clear();
            string[,] game = { { "#", "#", "#", "#", "#","#","#" },{ "#", "-", "-", "-", "-", "-", "#" }, { "#", "-", "-", "@", "-", "-", "#" }, { "#", "-", "-", "-", "-", "-", "#" }, { "#", "#", "#", "#", "#", "#", "#" } };
            string st = "";
            int x , i ;
            int pos1 =0, pos2 = 0;
            int[,] position = new int[9,9];
            while (st != "q")
            {
                for ( x = 0; x < game.GetLength(0); x++)
                {
                    for ( i = 0; i < game.GetLength(1); i++)
                    {
                        if (game[x, i] == "@")
                        {
                            pos1 = x;
                            pos2 = i;
                        }
                        Console.Write(game[x, i]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("wich direction do you wanna move? WASD");
                st = Console.ReadLine();

                if (st == "d" & game[pos1, pos2 + 1] != "#")
                {
                    game[pos1, pos2] = "-";
                    game[pos1, pos2 + 1] = "@";
                } else if (st == "a" & game[pos1, pos2 - 1] != "#")
                {
                    game[pos1, pos2] = "-";
                    game[pos1, pos2 - 1] = "@";

                } else if (st == "s" & game[pos1 + 1, pos2] != "#")
                {
                    game[pos1, pos2] = "-";
                    game[pos1 + 1, pos2] = "@";
                } else if (st == "w" & game[pos1 - 1, pos2] != "#")
                {
                    game[pos1, pos2] = "-";
                    game[pos1 - 1, pos2] = "@";
                }  else
                {
                    Console.WriteLine("you reached the limits or wrong movement");
                    Console.ReadKey();
                }
                Console.Clear();


            }
            
            
            
        }
    

        static public void WriteContentOfArray()
        {
            string[] colors = { "grån", "blå", "råd", "svart", "gul" };
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < colors.Length;i++)
            {
                temp.AppendLine($"{colors[i]} \t");
            }
            Console.WriteLine(temp.ToString());
        }

        static public void AddAndSubstract()
        {
            int[] numbers = { 1, 5, 8, 9, 6, 3, 4, 7 };
            int suma = 0;
            int substraction = 0;
            for (int i = 0; i < numbers.Length;i+=2)
            {
                suma += numbers[i] ;
                Console.WriteLine(suma);
            }
            for (int i = 1; i < numbers.Length ; i += 2)
            {
                 if (i == 1)
                 {
                     numbers[i] = -numbers[i];
                 }

                    substraction = substraction - numbers[i];  
                    Console.WriteLine(substraction);
            }
        }
        static public void WriteOddNumbers()
        {
            int[] numbers = new int [20];
           
            Random random = new Random();
            int amountOfodds = 0;
            int min = 1000;
            int max = 0;
            for (int i = 0; i < numbers.Length; i++ ) 
            {
                numbers[i] = random.Next(1,20);
                //check smallest number
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
                //check hights number
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                //check odds
                if (numbers[i] % 2 != 0)
                {
                    amountOfodds++;
                }
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine($"The smallest number is:\t{min}\t The highest number is:\t{max}\t the number of odds in the array are:\t {amountOfodds}");
        }

        //Get average of a array of numbers
        static public void GetAverage()
        {
            Console.WriteLine("Write the lenght of the array");
            string  s = Console.ReadLine();
            int size = int.Parse(s);
            int[] numbers = new int[size];
            double average = 0;
            Random random = new Random();
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1,100);
                average += numbers[i];
                temp.AppendLine($"{numbers[i]}\n");
            }
            average = average / numbers.Length;
            average = Math.Round(average,2);
            Console.WriteLine($"Numbers in the array:\n {temp}\n. Average of the array numbers  {average}");
        }

        static public void Paint1()
        {
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (x == y)
                        Console.Write("#");
                    else
                        Console.Write(".");
                }
                Console.WriteLine("");
            }

        }
        static public void Paint2()
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (x == y)
                        Console.Write("#");
                    else
                        Console.Write(".");
                }
                Console.WriteLine("");
            }

        }
        static public void Paint3()
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (x == y)
                    {
                        Console.Write("#");
                       
                    }
                    else if (x == 4 & y == 0)
                    {
                        Console.Write("#");
                    }
                    else if (x == 5 & y == 1)
                    {
                        Console.Write("#");
                    }
                    else if (x == 6 & y == 2)
                    {
                        Console.Write("#");
                    }
                    else if (x == 7 & y == 3)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                
                Console.WriteLine("");
            }

        }
        

        static public void Paint4()
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (x == 0 & y == 0)
                    {
                        Console.Write("#");
                    }
                    else if (x == 1 & y == 0)
                    {
                        Console.Write("#");
                    }
                    else if (x == 2 & y == 1)
                    {
                        Console.Write("#");
                    }
                    else if (x == 3 & y == 1)
                    {
                        Console.Write("#");
                    }
                    else if (x == 4 & y == 2)
                    {
                        Console.Write("#");
                    }
                    else if (x == 5 & y == 2)
                    {
                        Console.Write("#");
                    }
                    else if (x == 6 & y == 3)
                    {
                        Console.Write("#");
                    }
                    else if (x == 7 & y == 3)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine("");
            }
        }
        static public void Sevenb()
        {
            var temp = new StringBuilder();

            string[,] paint = { {"#",".", ".", "#", ".", ".", ".", "." }, { ".", "#", ".", ".", "#", ".", ".", "." }, { ".", ".", "#", ".", ".", ".", "#", ".", }, { ".", ".", ".", ".", "#", ".", ".", "#" } };
            for (int y = 0; y < paint.GetLength(0); y++)
            {
                for (int x = 0; x < paint.GetLength(1); x++)
                {
                   // temp.Append(paint[y,x]);
                    Console.Write("{0}",paint[y,x]+"");

                }
               // temp.AppendLine();
                Console.WriteLine();
            }

           // Console.Write(temp.ToString()+"\t");
        }

        static public void BubbleSort()
        {
            Random random = new Random();
            int[] numbers = new int[10];
            int temp = 0 ;
            for (int i = 0; i < numbers.Length; i++) 
            {
                numbers[i] = random.Next(1,50);
            }

            for (int i = 0; i < numbers.Length; i++) 
            {
                for (int x = 0; x < numbers.Length-1; x++)
                {
                    if (numbers[x] > numbers[x+1])
                    {
                        temp = numbers[x+1];
                        numbers[x+1] = numbers[x];
                        numbers[x] = temp;
                    }
                }
               
            }
            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine(numbers[i]);
            }

        }

    }
}

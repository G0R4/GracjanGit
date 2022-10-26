
using System;

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer zadania:");
            int taskNumber = int.Parse(Console.ReadLine());
            if (taskNumber == 1)
            {
                zad1();
            }
            else if (taskNumber == 2)
            {
                zad2();
            }
            else
            {
                Console.WriteLine(taskNumber + " - błędna opcja");
            }
        }


        static void zad1()
        {
            Console.WriteLine("Podaj liczbę a:"); 
            float a = float.Parse(Console.ReadLine()); 
            
            Console.WriteLine("Podaj liczbę b:");
            float b = float.Parse(Console.ReadLine());

            
            float math1 = a * a + b;
            float math2 = a + b;
            if (math2 == 0)
            {
                Console.WriteLine("Nie można dzielić przez zero");
            }
            else
            {
                math2 = math2 * math2;
                float result = math1 / math2;

                Console.WriteLine("Wartość wyrażenia wynosi: " + result);
               
            }
        }

        static void zad2()
        {
 

            Console.WriteLine("Podaj liczbę a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c:");
            double c = double.Parse(Console.ReadLine());

            double result; 
           

            if (c>0) 
            {
                result = a*a+b;
                Console.WriteLine("Wartość wyrażenia wynosi: " + result);
            }
            else
            {
               
                if (c<0) 
                {
                    result = a-b*b;
                    Console.WriteLine("Wartość wyrażenia wynosi: " + result);
                }
                else 
                {
                    if (a-b==0)
                    
                    {
                        Console.WriteLine("Próba dzielenia przez zero");
                    }
                    else
                    {
                        result = a-b;
                        result = 1/result;
                       
                        Console.WriteLine("Wartość wyrażenia wynosi: " + result);
                    }
                }
            }

           

       


        }
    }
}
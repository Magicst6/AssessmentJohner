using System;
namespace LogicalPrograms
{
    public class Program
    {
        public static void Main()
        {
            int firstNumber = 0, SecondNumber = 1, nextNumber, numberOfElements;
            Console.Write("Geben Sie die Anzahl an Elementen ein : ");
            try
            {
                numberOfElements = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("Geben Sie eine Zahl ein!" +  Environment.NewLine );
                Main();
                numberOfElements = 0;
            }
            if (numberOfElements < 2)
            {
                Console.Write("Bitte geben Sie eine Zahl größer als 2 an!");
            }
            else
            {
                //First print first and second number
                Console.Write(firstNumber + " " + SecondNumber + " ");
                //Starts the loop from 2 because 0 and 1 are already printed
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
            }

            Console.ReadKey();
        }
    }
}

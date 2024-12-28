using System;

public class Star
{
    public static void Main(string[] args)
    {
        int row = 5;
        for (int i = 1; i <= row; i++)
        {

            for (int j = 1; j <= row-i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

        }
    }
}
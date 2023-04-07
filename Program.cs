using System;
using System.Numerics;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] Numbers = input.Replace(".",",").Split(' ');
        double[] vector = new double[Numbers.Length];
        for (int i = 0; i < Numbers.Length; i++)
        {
            double num = double.Parse(Numbers[i]);
            vector[i] = num;
        }

        double answer = 0;

        foreach (double num in vector)
        {
            answer += num * num;
        }
        answer = Math.Sqrt(answer);
        string answerStr = Convert.ToString(answer).Replace(",", ".");


        Console.WriteLine(answerStr);
    }
}
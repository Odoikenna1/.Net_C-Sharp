using System;
namespace studentGrade;

public class StudentGrade
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the student grade calculator. \n");

        int numberOfStudents = inputInt("\nHow many students do you have?  \n");
        int numberOfSubjects = inputInt("\nHow many subjects do they offer?  \n");
        
        int[,] arrayOfScores = new int[numberOfStudents, numberOfSubjects];

        for (int x = 0; x < numberOfStudents; x++)
        {
            for (int i = 0; i < numberOfSubjects; i++)
            {
                Console.Write($"Enter score {i + 1}:  ");
                int scores = int.Parse(Console.ReadLine());
                arrayOfScores[x, i] = scores;
            }
        }

        // Console.WriteLine();
        Console.Write("\nThe scores entered are: \n" + string.Join(", ", arrayOfScores));
    }

    public static int inputInt(string textPrompt)
    {
        Console.Write(textPrompt, " ");
        int userInput = int.Parse(Console.ReadLine());
        return userInput;
    }
}
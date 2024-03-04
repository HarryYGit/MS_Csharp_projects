using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

// student scores
int[] sophiaScores =  { 90, 86, 87, 98, 100 };
int[] andrewScores =  { 92, 89, 81, 96, 90 };
int[] emmaScores =  { 90, 85, 87, 98, 68 };
int[] loganScores =  { 90, 95, 87, 88, 96 };

//student names
string[] studentNames = {"Sophia", "Andrew", "Emma", "Logan"};

// sophiaScore = (decimal)sophiaSum / currentAssignments;
// andrewScore = (decimal)andrewSum / currentAssignments;
// emmaScore = (decimal)emmaSum / currentAssignments;
// loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");

//print student names
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
    {
        int sophiaSum = 0;

        decimal sophiaScore;

        foreach (int score in sophiaScores)
        {
            sophiaSum += score;
        }

        sophiaScore = (decimal)sophiaSum / currentAssignments;

    }

    
    Console.WriteLine("Student\t\tGrade\n");



}

// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

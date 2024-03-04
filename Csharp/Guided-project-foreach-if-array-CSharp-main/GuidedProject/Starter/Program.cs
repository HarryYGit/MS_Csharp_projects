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

//student score array
int[] studentScores = new int[10];

Console.WriteLine("Student\t\tGrade\n");

//print student names
foreach (string name in studentNames)
{
    string currentStudent = name;

    // match student scores with names
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    
        int sumAssignmentScores = 0;

        decimal currentStudentGrade = 0;

        foreach (int score in studentScores)
        {
            sumAssignmentScores += score;
        }

        currentStudentGrade = (decimal)sumAssignmentScores / currentAssignments;

        System.Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");

}

// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

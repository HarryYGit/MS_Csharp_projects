using System;

// initialize variables - graded assignments 
// int currentAssignments = 5;
int examAssignments = 5; //change for extra credits

// student scores
// int[] sophiaScores =  { 90, 86, 87, 98, 100 }; 
int[] sophiaScores =  { 90, 86, 87, 98, 100, 94, 90 }; //extra credits
int[] andrewScores =  { 92, 89, 81, 96, 90, 89 };
// int[] emmaScores =  { 90, 85, 87, 98, 68 };
int[] emmaScores =  { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores =  { 90, 95, 87, 88, 96, 96 };

//add more students
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 }; 


//student names
string[] studentNames = {"Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"};

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
        
    //add more student names
    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;

    else
        continue;
    
        int sumAssignmentScores = 0;

        decimal currentStudentGrade = 0;

        //for extra credits
        int gradedAssignmnts = 0;

        foreach (int score in studentScores)
        {
            //assignment counter for graded assignments
            gradedAssignmnts += 1;

            if (gradedAssignmnts <= examAssignments)
            {
                sumAssignmentScores += score; //sum first 5 assignments, which is the original assignments
            }
            else
            {
                sumAssignmentScores += score / 10; //sum extra credits as 10% bonus points to exam score
            }
        }

        
        // currentStudentGrade = (decimal)sumAssignmentScores / currentAssignments;
        currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

        //creare student scores if-elseif-else satatement
        string currentStudentLetterGrade = "";
        if (currentStudentGrade >= 97)
        {
            currentStudentLetterGrade = "A+";
        }
        else if (currentStudentGrade >= 93)
        {
            currentStudentLetterGrade = "A";
        }
        else if (currentStudentGrade >= 90)
        {
            currentStudentLetterGrade = "A-";
        }
        else if (currentStudentGrade >= 87)
        {
            currentStudentLetterGrade = "B+";
        }
        else if (currentStudentGrade >= 83)
        {
            currentStudentLetterGrade = "B";
        }
        else if (currentStudentGrade >= 80)
        {
            currentStudentLetterGrade = "B-";
        }
        else if (currentStudentGrade >= 77)
        {
            currentStudentLetterGrade = "C+";
        }
        else if (currentStudentGrade >= 73)
        {
            currentStudentLetterGrade = "C";
        }
        else if (currentStudentGrade >= 70)
        {
            currentStudentLetterGrade = "C-";
        }
        else if (currentStudentGrade >= 67)
        {
            currentStudentLetterGrade = "D+";
        }
        else if (currentStudentGrade >= 63)
        {
            currentStudentLetterGrade = "D";
        }
        else if (currentStudentGrade >= 60)
        {
            currentStudentLetterGrade = "D-";
        }
        else
        {
            currentStudentLetterGrade = "F";
        }


        System.Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t\t{currentStudentLetterGrade}");

}

// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

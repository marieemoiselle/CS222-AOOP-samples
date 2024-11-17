using System;

int score;
Console.Write("Enter score: ");
score = Convert.ToInt32(Console.ReadLine());

if(score >= 90 && score <= 100){
    Console.Write("Grade: A");
    }

else if(score >= 80 && score <= 89){
        Console.Write("Grade: B");
    }

else if(score >= 70 && score <= 79){
        Console.Write("Grade: C");
    }

else if(score >= 60 && score <= 69){
        Console.Write("Grade: D");
    }

else{
        Console.Write("Grade: F");
    }
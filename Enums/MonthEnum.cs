using System;

enum Months {
    January,
    February,
    March=5,
    April, // 6
    May,  //  7
    June, // 8 
    July,  // 9
    August, // 10
    September, // 11
    October, //12 
    November, //13
    December // 14
}

int january = (int) Months.January;
int myMonth = (int) Months.December;
Console.WriteLine($"January: {january}");
Console.WriteLine($"December: {myMonth}");
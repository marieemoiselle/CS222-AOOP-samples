using System;

enum Season {
    Winter,
    Spring,
    Summer,
    Autumn
}

Season mySeason = Season.Spring; 
switch (mySeason){
    case Season.Winter:
        Console.WriteLine("It is winter season.");
        break;
    case Season.Spring:
        Console.WriteLine("It is spring season.");
        break;
    case Season.Summer:
        Console.WriteLine("It is summer season.");
        break;
    case Season.Autumn:
        Console.WriteLine("It is autumn season.");
        break;
}
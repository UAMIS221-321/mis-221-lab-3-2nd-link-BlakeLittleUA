using System;
class Program
{
    static string GetEnjoymentLevel() {
        Console.WriteLine("What enjoyment level would you prefer?");
        string enjoymentLevel = Console.ReadLine();
        return enjoymentLevel;
    }

    static string GetStadiumRecommendation(string enjoymentLevel) {
        string stadium = "Unknown Stadium";
        if (enjoymentLevel == "Epic") {
            stadium = "Saban Field at Bryant-Denny Stadium";
        }
        if (enjoymentLevel == "Fun") {
            stadium = "Tiger Stadium";
        }
        if (enjoymentLevel == "Average") {
            stadium = "Jordan-Hare Stadium";
        }
        if (enjoymentLevel == "Boring") {
            stadium = "Neyland Stadium";
        }
        return stadium;
    }

    static string GetGameRecommendation(string stadium) {
        string game = "Unknown Game";
        if (stadium == "Saban Field at Bryant-Denny Stadium"){
            game = "Auburn";
        }
        if (stadium == "Tiger Stadium"){
            game = "Alabama";
        }
        if (stadium == "Jordan-Hare Stadium"){
            game = "Kentucky";
        }
        if (stadium == "Neyland Stadium"){
            game = "Kent State";
        }
        return game;
    }



    static void  DisplayStadiumDetails(string stadium, string game){
        Console.WriteLine("for your selected enjoyment level, the best game to watch is " + game + " at " + stadium);
    }

    static void Main(string[] args) {
        string enjoymentLevel = GetEnjoymentLevel();

        string stadium = GetStadiumRecommendation(enjoymentLevel);

        string game = GetGameRecommendation(stadium);

        DisplayStadiumDetails(stadium, game);
    }
}
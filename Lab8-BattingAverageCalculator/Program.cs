
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_BattingAverageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //formulas:
            //Batting Average =  Non-Zero At Bats / Total # At Bats 
            //Slugging Percentage = Total # of Bases Earned / Total # At Bats


            float BattingAverage;
            float SluggingPercentage;
            float[] AtBatResults = { 0, 1, 2, 3, 4 };  //TO DO - validate so that only these 5 choices can be entered 
            
            //GET NUMBER OF PLAYERS
            Console.WriteLine("Please enter number of players:");
            int NumberOfPlayers = int.Parse(Console.ReadLine());

            //GET NUMBER OF AT BATS PER PLAYER
            Console.WriteLine("Please enter number of times at-bats for each player");
            int NumberOfAtBats = int.Parse(Console.ReadLine());

            //ARRAY TO HOLD AT EACH PLAYERS AT-BAT STATS 
            float[,] BattingStats = new float[NumberOfPlayers, NumberOfAtBats];


            //GET THE NUMBER PLAYERS AND ALL OF THEIR AT BATS

            for (int Row = 0; Row < NumberOfPlayers; Row++)  //for each player....
            {
                Console.WriteLine($"Please enter " + NumberOfPlayers + " Batting Results (press enter after each entry) for each player {Row + 1}");

                for (int Column= 0; Column < NumberOfAtBats; Column++)  //....add this many at bat stats
                {
                    BattingStats[Row, Column] = float.Parse(Console.ReadLine()); //this collects the information for the array and puts the player in the row and the stats in the column
                }
            }
             


            for (int Row = 0; Row < NumberOfPlayers; Row++)
            {
                Console.WriteLine($"Enter the number of grades for student {i + 1}");
                int Columns = int.Parse(Console.ReadLine());
            }

            StudentGradeSheet[i] = new int[Columns];

            //second array/loop needed (modify)
            for (int Row = 0; Row < NumberOfStudents; Row++)
            {
                for (int Column = 0; Column < StudentGradeSheet[Row].Length; Column++)
                {
                  //  StudentGradeSheet[Row][Column] = int.Parse....//what goes here
                }
            }


            //need a 3rd array/loop to do the calculations (modify)
            for (int Row = 0; Row < NumberOfStudents; Row++)
            {
                float Sum = 0; //set sum to 0 becuase each student has their own sum. Start with 0 and add each grade to the 0. When it goes into the 2nd loop, it will add the grades from the prior student unless you re-set it to 0

                for (int Column = 0; Column < NumberOfGrades; Column++)
                {
                    Sum = Sum + StudentGradeSheet[Row, Column];
                }

                Console.WriteLine($"Letter grade for student {Row + 1} is {CalculateLetterGrade(Sum)}");

            }



        }


        //CONTINUE METHOD
        public static string Continue()
        {
        }

        //ENDGAME METHOD
        public static string EndGame()
        {
        }


        ////PLAY OR END GAME?
        //bool EndGame = false;  //start with EndGame set to false in order to play the game

        //Console.WriteLine("Would you like to roll the dice? Y/N ");
        //        string RollDice = Console.ReadLine();


        //    //DON'T ROLL THE DICE - END GAME
        //    if (RollDice == "N")
        //    {
        //        EndGame = true;  //set EndGame to true in order to exit
        //        Console.WriteLine("Thanks for playing! Goodbye!");
        //    }


}
}

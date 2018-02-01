
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab8_BattingAverageCalculator
{

    class Methods
    {
        //METHOD TO CALCULATE AVERAGES
        public static float CalculateAverage(float sum1, int bases)
        {
            return sum1 / bases;

        }


       

    }

    class Program
    {
        static void Main(string[] args) //MAIN METHOD
        {

            bool EndGame = false;  //start with EndGame set to false in order to play the game

            while (EndGame == false)
            {
                //GET NUMBER OF PLAYERS
                Console.WriteLine("Please enter number of players: \n");
                int NumberOfPlayers = int.Parse(Console.ReadLine());



                //GET NUMBER OF AT BATS PER PLAYER
                Console.WriteLine("Please enter number of at-bats for each player \n");
                int NumberOfAtBats = int.Parse(Console.ReadLine());

                //ARRAY TO HOLD AT EACH PLAYER AND THEIR AT-BAT STATS 
                float[,] BattingStats = new float[NumberOfPlayers, NumberOfAtBats];


                //READ THE NUMBER PLAYERS AND ALL OF THEIR AT BATS

                for (int Row = 0; Row < NumberOfPlayers; Row++)  //for each player....
                {

                   
                  //  NumberOfPlayers = int.Parse(Console.ReadLine());

                    for (int Column = 0; Column < NumberOfAtBats; Column++)  //....add this many at bat stats

                    {
                        
                        Console.WriteLine("Please enter at bat result:");
                        int[] AtBatResults = { 0, 1, 2, 3, 4 };  //TO DO - validate so that only these 5 choices can be entered 

                      //  if (!Regex.Match(AtBatResults, @"\d{[0,4]}$").Success)  //validation
                        //    throw new Exception(message: "Please enter 0, 1, 2, 3, or 4");
                        

                        BattingStats[Row, Column] = float.Parse(Console.ReadLine()); //this collects the information for the array and puts the player in the row and the stats in the column
                    }

                }

                //formulas:
                //Batting Average =  Non-Zero At Bats / Total # At Bats 
                //Slugging Percentage = Total # of Bases Earned / Total # At Bats

                for (int Row = 0; Row < NumberOfPlayers; Row++)
                {
                    float Sum1 = 0; //set sum to 0 bc each batter has their own sum. Start with 0 and add each at bat to the 0. When it goes into the 2nd loop, it will add the at bats from the prior player unless you re-set it to 0
                    int Count = 0;

                    for (int Column = 0; Column < NumberOfAtBats; Column++)
                    {
                        Sum1 += BattingStats[Row, Column];
                        if (BattingStats[Row, Column] > 0) //this skips the 0s
                        {
                            Count++;   //this only counts the nonzero at bats
                        }

                    }
                    Console.WriteLine($"Player{Row + 1} results are");
                    Console.WriteLine(new string('*', 20));
                    Console.WriteLine($"The slugging average for Player{Row + 1} is {Methods.CalculateAverage(Sum1, NumberOfAtBats)}\n");
                    Console.WriteLine($"The batting average for Player{Row + 1} is {Methods. CalculateAverage(Count, NumberOfAtBats)}\n");


                }

                //PLAY OR END GAME?


                Console.WriteLine("Would you like to enter more stats? Y/N");
                string Continue = Console.ReadLine();
                if (Continue == "N")
                {
                    EndGame =  true;
                    Console.WriteLine("Thanks for playing! Goodbye!");
                    
                }

            }
        }


        
    }
}






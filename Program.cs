﻿using System;
using System.Xml.Linq;

namespace SnakeLadderGame
{
    class Program
    {
        public const int win = 100;
        public const int ladder = 1;
        public const int snake = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            int position1 = 0;
            int position2 = 0;
            bool playerOne = true;
            bool playerTwo = false;
            while (position1 < win && position2 < win)
            {
                if (playerOne)
                {


                    Random random = new Random();
                    int diceOutcome = random.Next(1, 7);
                    int checkOptions = random.Next(0, 3);
                    switch (checkOptions)
                    {
                        case ladder:

                            if (position1 + diceOutcome <= 100)
                            {
                                position1 += diceOutcome;
                            }
                            playerOne = true;

                            break;
                        case snake:
                            if (position1 - diceOutcome < 0)
                            {
                                position1 = 0;
                            }
                            else
                            {
                                position1 -= diceOutcome;
                            }
                            playerTwo = true;
                            playerOne = false;

                            break;
                        default:
                            playerTwo = true;
                            playerOne = false;
                            break;

                    };
                }
                else
                {
                    Random random = new Random();
                    int diceOutcome = random.Next(1, 7);
                    int checkOptions = random.Next(0, 3);
                    switch (checkOptions)
                    {
                        case ladder:
                            if (position2 + diceOutcome <= 100)
                            {
                                position2 += diceOutcome;
                            }
                            playerTwo = true;
                            break;
                        case snake:
                            if (position2 - diceOutcome < 0)
                            {
                                position2 = 0;
                            }
                            else
                            {
                                position2 -= diceOutcome;
                            }
                            playerTwo = false;
                            playerOne = true;
                            break;
                        default:
                            playerTwo = false;
                            playerOne = true;
                            break;
                    }
                }
            }

            if (position1 > position2)
            {
                Console.WriteLine("Player1 won the game");
            }
            else
            {
                Console.WriteLine("Player2 won the game");
            }
        }

    }
}                   
                    
                    
                    
                    
                    
                    
                    
               
                
                
                
                
                
                
                
                
            
                 
                 
   
                 
            
        
    











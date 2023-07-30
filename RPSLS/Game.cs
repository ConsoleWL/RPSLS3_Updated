﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;
        int numberOfPlayers;


        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");

            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Rock crushes Lizard");

            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Paper disproves Spock");

            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Scissors cuts Paper");

            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Lizard eats Paper");

            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("Spock smashes Scissors");

            Console.WriteLine("\nGame will be best out of 3!");

        }

        public void ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("\nChoose number of players 1 or 2:");

            while (true)
            {
                string temp = Console.ReadLine();

                if (temp == "1")
                {
                    numberOfPlayers = 1;
                    break;
                }
                if(temp == "2")
                {
                    numberOfPlayers = 2;
                    break;
                }
                else
                {
                    Console.WriteLine("\nWrong input. Choose between 1 or 2");
                }
            }
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {

        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
        }
    }
}

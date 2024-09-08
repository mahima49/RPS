using System;
using System.Collection.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;
using System.math;

namespace ROCKPAPERSCISSORS
{
    class program
    {
        static void main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;

            console.Write("choose between ROCK , PAPER AND SCISSORS:    ");
            inputPlayer = console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();

            Random rnd = new Random();

            randomInt = rnd.Next(1,4);

            switch (randomInt)
            {
                case 1:
                inputCPU = "ROCK";
                console.WriteLine("Rock");
                if(inputPlayer == "ROCK")
                {
                    console.WriteLine("DRAW!\n\n")
                }
                else if(inputPlayer == "paper")
                {
                    console.WriteLine("PLAYER WINS!\n\n")
                    scorePlayer++;
                }
                else if(inputPlayer == "SCISSORS")
                {
                    console.WriteLine("CPU WINS!\n\n")
                    scoreCPU++;
                }
                break;
                case 2:
                inputCPU = "PAPER";
                console.WriteLine("PAPER");
                if(inputPlayer == "PAPER")
                {
                    console.WriteLine("DRAW!\n\n")
                }
                else if(inputPlayer == "SCISSORS")
                {
                    console.WriteLine("PLAYER WINS!\n\n")
                    scorePlayer++;
                }
                else if(inputPlayer == "ROCK")
                {
                    console.WriteLine("CPU WINS!\n\n")
                    scoreCPU++;
                }
                break;
                case 3:
                inputCPU = "SCISSORS";
                console.WriteLine("SCISSORS");
                if(inputPlayer == "SCISSORS")
                {
                    console.WriteLine("DRAW!\n\n")
                }
                else if(inputPlayer == "ROCK")
                {
                    console.WriteLine("PLAYER WINS!\n\n")
                    scorePlayer++;
                }
                else if(inputPlayer == "PAPER")
                {
                    console.WriteLine("CPU WINS!\n\n")
                    scoreCPU++;
                }
                break;
                default:
                console.WriteLine("Invalid Entry!");
                break;

            }
        }
    }
}
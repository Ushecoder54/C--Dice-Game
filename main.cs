using System;

namespace Dice-Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;
            
            Random random = new Random();
            
            for (int i - 0; i < length; i++)
            {
                Console.writeLine("press any key to roll the dice.");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.writeLine("You rolled a " + playerRandomNum);

                Console.writeLine("...");
                System.Threading.Thread.Sleep(1000);
                
                enemyRandomNum = random.Next(1, 7);
                Console.writeLine("enemy AI rolled a " + enemyRandomNum);

                if(playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    console.writeLine("Player wins this round");
                }
                else if(playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.writeLine("Enemy wins this round!");
                }
                else
                {
                    Console.writeLine("Draw!");
                }
                
                
                Console.writeLine("The score is now - Player : " + playerPoints + ", Enemy : " enemyPoints + ",");
                Console.writeLine()
            }

            if(playerPoints > enemyPoints)
            {
                Console.writeLine("You win!");
            }
            else if(playerPoints < enemyPoints)
            {
                Console.writeLine("You lose!");
            }
            else
            {
                Console.writeLine("Its a draw!")
            }
            
            Console.ReadKey();
        }
    }
}
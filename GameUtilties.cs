using System;

namespace MIS321PA2
{
    public class GameUtilities
    {
        private static int Count = 1;
        public static Player PlayerName(){
            System.Console.WriteLine("Player " + Count + " Name:");
            string temp = "";
            temp = System.Console.ReadLine();
            while(temp == "")
            {
                System.Console.WriteLine("Please choose a valid name!");
                System.Console.WriteLine("Player " + Count + " Name:");
                temp = System.Console.ReadLine();
            }
            Player one = new Player() {Name = temp};
            return one;
        }
        public static void GameRules(){
            System.Console.WriteLine("Players begin by choosing between three characters.\n1 - Jack Sparrow \n2 - Will Turner \n3 - Davy Jones \nPress any key to continue.");
            Console.ReadKey();
            System.Console.WriteLine("Each character gets a 20% damage bonus against their respective rival. \nJack Sparrow beats Will Turner \nWill Turner beats Davy Jones \nDavy Jones beats Jack Sparrow \nPress any key to continue.");
            Console.ReadKey();
            System.Console.WriteLine("The player who goes first is randomized.\nCharacters start with 100 health \nAt the start of each turn your character is generated a random Max Power, Attack Power, and Defence. \nEach turn a player has the option to attack and defend. \nThe turn ends after the player attacks or defends.\nPress any Key to continue.");
            Console.ReadKey();
            System.Console.WriteLine("Damage is calculated by (Attack Power - Defence Power) * Bonus \nAttack attempts to damage the opponent \nBlock skips your attack but makes your defence 75% of your max power for your turn\nWhen a character reaches 0 Health they lose");
    
        }
        public static Character PlayerCharacter(Player playerOne){
            System.Console.WriteLine(playerOne.Name + ":");
            //Displays the character options
            string charater = Menus.CharacterMenu();

            if(charater == "1")
            {
                Character temp = new JackSparrow();
                return temp;
            }
            else if(charater == "2")
            {
                Character temp = new DavyJones();
                return temp;
            }
            else if(charater == "3")
            {
                Character temp = new WillTurner();
                return temp;
            }
            else
            {
                Character temp = new Character();
                return temp;
            }
        
        }

        public static void DamageBonus(ref Player playerOne, ref Player playerTwo){
            if((playerOne.character.Name == "Jack Sparrow" && playerTwo.character.Name == "Will Turner") || (playerOne.character.Name == "Will Turner" && playerTwo.character.Name == "Davy Jones") || (playerOne.character.Name == "Davy Jones" && playerTwo.character.Name == "Jack Sparrow"))
            {
                playerOne.character.Bonus = 1.2;
            }
            else if((playerTwo.character.Name == "Jack Sparrow" && playerOne.character.Name == "Will Turner") || (playerTwo.character.Name == "Will Turner" && playerOne.character.Name == "Davy Jones") || (playerTwo.character.Name == "Davy Jones" && playerOne.character.Name == "Jack Sparrow"))
            {
                playerTwo.character.Bonus = 1.2;
            }
        }
        public static void RandomizeTurn(ref Player playerOne, ref Player playerTwo){
            Random rng = new Random();
            int temp = rng.Next(-1,0);

            if(temp == -1)
            {
                Player tempPlayer = new Player();
                tempPlayer = playerOne;
                playerOne = playerTwo;
                playerTwo = tempPlayer;
            }
        }
        public static void GameTurn(string turn, Player playerOne, Player playerTwo){
           if(playerTwo.character.Health >= 0)
           {
                if(turn == "1")
                {
                    playerOne.character.attackBehavior.Attack(playerOne, playerTwo);
                    
                }
                else if(turn == "2")
                {
                    double temp =  playerOne.character.MaxPower * 0.75;
                    double defence = Math.Round(temp, MidpointRounding.AwayFromZero);
                    playerOne.character.Defence = defence;
                }
           }
        }
        public static void RandomizeCharacterStats(Player playerOne){
            Random random = new Random();
            int max = random.Next(1,100);
            playerOne.character.MaxPower = max;
            int attack = random.Next(1, playerOne.character.MaxPower);
            playerOne.character.AttackPower = attack;
            int defence = random.Next(1,playerOne.character.MaxPower);
            playerOne.character.Defence = defence;
        }
        public static void DeclareWinner(Player playerOne, Player playerTwo){
            if(playerOne.character.Health > 0)
            {
                System.Console.WriteLine(playerOne.Name + " wins!");
            }
            else
            {
                System.Console.WriteLine(playerTwo.Name + " wins!");
            }
        }
        public static void IncCount(){
            Count++;
        }
        public static void ResetCount(){
            Count = 1;
        }
    }
}
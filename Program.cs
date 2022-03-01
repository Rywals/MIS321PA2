using System;

namespace MIS321PA2
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainMenu = Menus.MainMenu();

            while(mainMenu != "3")
            {
                if(mainMenu == "1")
                {
                    //Sets player one name
                    Player playerOne = GameUtilities.PlayerName();
                    GameUtilities.IncCount();
                    //Sets player two name
                    Player playerTwo = GameUtilities.PlayerName();
                    GameUtilities.ResetCount();
                    //Sets player one character
                    playerOne.character = GameUtilities.PlayerCharacter(playerOne);
                    //Sets player two character
                    playerTwo.character = GameUtilities.PlayerCharacter(playerTwo);
                    //Sets the damage Bonus
                    GameUtilities.DamageBonus(ref playerOne, ref playerTwo);
                    //Determines turn order
                    GameUtilities.RandomizeTurn(ref playerOne, ref playerTwo);
                    //Displays who goes first
                    Menus.DisplayTurnOrder(playerOne);
                    //Randomize player two stats
                    GameUtilities.RandomizeCharacterStats(playerTwo);

                    while((playerOne.character.Health > 0) && (playerTwo.character.Health > 0))
                    {
                        //Randomize player one stats
                        GameUtilities.RandomizeCharacterStats(playerOne);
                        //Displays Player one stats
                        Menus.DisplayPlayerStats(playerOne);
                        //Displays Attack or Block turn options
                        string turn = Menus.TurnOptions(playerOne);
                        //Attacks or defends
                        GameUtilities.GameTurn(turn, playerOne, playerTwo);
                        //Randomize player two stats
                        GameUtilities.RandomizeCharacterStats(playerTwo);
                        //Displays Stats for player two
                        Menus.DisplayPlayerStats(playerTwo);
                        //Display menu option for player two
                        turn = Menus.TurnOptions(playerTwo);
                        //Attacks or defends for player two
                        GameUtilities.GameTurn(turn, playerTwo, playerOne);
                    }
                    //
                    GameUtilities.DeclareWinner(playerOne, playerTwo);
                }
                else if(mainMenu == "2")
                {
                    //Display Rules
                    GameUtilities.GameRules();
                }

                mainMenu = Menus.MainMenu();
            }
        }
    }
}

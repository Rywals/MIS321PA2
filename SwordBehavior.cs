using MIS321PA2.interfaces;
using System;

namespace MIS321PA2
{
    public class SwordBehavior : IAttackBehavior
    {
        public void Attack(Player playerOne, Player playerTwo){
             double temp = (playerOne.character.AttackPower - playerTwo.character.Defence) * (playerOne.character.Bonus);
            if(temp > 0)
            {
                double damage = Math.Round(temp, MidpointRounding.AwayFromZero);
                System.Console.WriteLine("You Stab your opponent!");
                System.Console.WriteLine(playerOne.character.Name +" Attack Power: " + playerOne.character.AttackPower + "\n" + playerTwo.character.Name + "Defence Power: " + playerTwo.character.Defence + "\nDamage Bonus: " + playerOne.character.Bonus);
                System.Console.WriteLine("\nThey take " + damage + " damage! \n" + playerTwo.Name + " Health: " + (playerTwo.character.Health - damage) +"\n");
                playerTwo.character.Health = playerTwo.character.Health - damage;
            }
            else
            {
                double damage = 0;
                System.Console.WriteLine("You swing your sword and miss!");
                System.Console.WriteLine(playerOne.character.Name +" Attack Power: " + playerOne.character.AttackPower + "\n" + playerTwo.character.Name + "Defence Power: " + playerTwo.character.Defence + "\nDamage Bonus: " + playerOne.character.Bonus);
                System.Console.WriteLine("\nThey take " + damage + " damage! \n" + playerTwo.Name + " Health: " + (playerTwo.character.Health - damage) +"\n");
            }
        }
    }
}
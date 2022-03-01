namespace MIS321PA2
{
    public class Menus
    {
        public static string MainMenu(){
            System.Console.WriteLine("Welcome to Battle of Calypso! Please Select from the following menu options. \n1 - Start Game \n2 - View Rules \n3 - Exit");
            string temp = "";
            temp = System.Console.ReadLine();
            while(temp != "1" && temp != "2" && temp != "3")
            {
                System.Console.WriteLine("Please choose a valid selection");
                System.Console.WriteLine("1 - Start Game \n2 - View Rules \n3 - Exit");
                temp = System.Console.ReadLine();
            }
            return temp;
        }
        public static string CharacterMenu(){
            System.Console.WriteLine("Choose your character \n1 - Jack Sparrow \n2 - Davy Jones \n3 - Will Turner");
            string temp = "";
            temp = System.Console.ReadLine();
            while(temp != "1" && temp != "2" && temp != "3")
            {
                System.Console.WriteLine("Please choose a valid selection.");
                System.Console.WriteLine("Choose your character \n1 - Jack Sparrow \n2 - Davy Jones \n3 - Will Turner");
                temp = System.Console.ReadLine();
            }
            return temp;
        }
        public static void DisplayTurnOrder(Player playerOne){
            System.Console.WriteLine(playerOne.Name + " Goes First!");
        }
        public static void DisplayPlayerStats(Player playerOne){
            if(playerOne.character.Health> 0)
            {
                System.Console.WriteLine(playerOne.Name + "'s Turn:\n" + "Max Power: " +playerOne.character.MaxPower + "\nHealth: " + playerOne.character.Health + "\nAttackPower: " + playerOne.character.AttackPower + "\nDefence: " + playerOne.character.Defence);
            }
        }
        public static string TurnOptions(Player playerOne){
            if(playerOne.character.Health > 0)
            {
                System.Console.WriteLine(playerOne.Name + ":\n1 - Attack \n2 - Defend");
                string temp = System.Console.ReadLine();

                while(temp != "1" && temp != "2")
                {
                    System.Console.WriteLine("Please Choose a Valid Option!");
                    System.Console.WriteLine(playerOne.Name + ":\n1 - Attack \n2 - Defend");
                    temp = System.Console.ReadLine();
                }
                return temp;
            }
            else{
                string temp = "";
                return temp;
            }
        }
    }
}
namespace MIS321PA2
{
    public class WillTurner : Character
    {
        public WillTurner(){
            Name = "Will Turner";
            attackBehavior = new SwordBehavior();
        }
    }
}
using MIS321PA2.interfaces;

namespace MIS321PA2
{
    public class Character
    {
        public string Name {get; set;}
        public int MaxPower {get; set;}
        public double Health = 100;
        public int AttackPower {get; set;}
        public double Defence {get; set;}
        public double Bonus = 1;
        public IAttackBehavior attackBehavior {get; set;}

        public Character(){
            attackBehavior = new SwordBehavior();
        }
    }
}
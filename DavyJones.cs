namespace MIS321PA2
{
    public class DavyJones : Character
    {
        public DavyJones(){
            Name = "Davy Jones";
            attackBehavior = new CannonBehavior();
        }
    }
}
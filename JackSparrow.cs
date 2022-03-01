namespace MIS321PA2
{
    public class JackSparrow : Character
    {
        public JackSparrow(){
            Name = "Jack Sparrow";
            attackBehavior = new DistractBehavior();
        }
    }
}
namespace De_fyra_OOP_principerna
{
    // här ska vi skapa en en klass Shape med en metod Draw 

    public  abstract class Shape
    {
        public abstract void Draw();
       
    }

    // här ska vi skapa en subklass square som ärver från Shape och override:ar (skriver över) Draw
    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Ritar en fyrkant");
        }
    }

    // här ska vi skapa entill subklass Circle som ärver från Shape och override:ar (skriver över) Draw 
    public class Circle : Shape
        {
        public override void Draw()
        {
            Console.WriteLine("Ritar en cirkel");
        }
    }




}

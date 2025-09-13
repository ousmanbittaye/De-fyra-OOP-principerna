

namespace De_fyra_OOP_principerna
{
    public abstract class Animal
    {
        // Här ska jag skapa en basklass Animal med en metod MakeSound som är abstrakt.

        public abstract void MakeSound();
    }
    public class Lejon : Animal
    {
        // Här skapar jag en subklass lejon som ärver från Animal och implementerar MakeSound-metoden.

        public override void MakeSound()
        {
            System.Console.WriteLine("raawww, raaww!");
        }


    }
    public class Horse : Animal
    {
        // Här skapar jag en subklass horse som ärver från Animal och implementerar MakeSound-metoden.

        public override void MakeSound()
        {
            Console.WriteLine("iiihh - haaah!");



        }
    }
}
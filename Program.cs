namespace De_fyra_OOP_principerna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kör vi programmet och testar vår arv
           Truck myTruck = new Truck();
              myTruck.Make = "scania";
                myTruck.Model = "l-serien";
                myTruck.Year = 2020;
                myTruck.Start();

            Car myCar = new Car();
            myCar.Make = "Volvo";
            myCar.Model = "V90";
            myCar.Year = 2022;
            myCar.Color = "Blue";
            myCar.Honk();
            
            //  här kör vi programmet och testar vår polymorfism

            Shape circle1 = new Circle();
            circle1.Draw();
            Shape square1 = new Square();
            square1.Draw();

            // kör vi programmet och testar vår inkapsling

            // här ska jag skapa en instans av BankAccount och göra några insättningar och uttag

            BankAccount account1 = new BankAccount();
            account1.Deposit(1000);
            account1.Withdraw(300);

            Console.WriteLine($"Ditt saldo är: {account1.getbalance(0)} kr.");

            // här körs programmet och testar vår abstraktion
            Animal Lejon = new Lejon();
            Lejon.MakeSound();

            Animal Horse = new Horse();
            Horse.MakeSound();


        }
    }
}

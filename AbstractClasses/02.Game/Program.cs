namespace _02.Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            warrior.Name = "Warrior";
            warrior.Health = 100;
            warrior.AttackPower = 10;

            Mage mage = new Mage();
            mage.Name = "Mage";
            mage.Health = 50;
            mage.AttackPower = 5;
            mage.Mana = 50;

            while (warrior.IsAlive() && mage.IsAlive())
            {
                Console.WriteLine(warrior.Attack());
                mage.TakeDamage(warrior.AttackPower);
                Console.WriteLine($"Mage health: {mage.Health}");

                Console.WriteLine(mage.Attack());
                warrior.TakeDamage(mage.AttackPower);
                Console.WriteLine($"Warrior health: {warrior.Health}");
            }

            if (warrior.IsAlive())
            {
                Console.WriteLine("Warrior wins!");
            }
            else
            {
                Console.WriteLine("Mage wins!");
            }

        }
    }
}

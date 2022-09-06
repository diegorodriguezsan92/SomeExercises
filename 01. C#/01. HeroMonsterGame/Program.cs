using System;

namespace heroMonsterGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroHealth = 20;
            int monsterHealth = 20;

            Random counterRoleAttacks = new Random();
            int hurt = 0;
            int counter = 1;
            bool counterRoleMaster = true;

            while (counterRoleMaster)
            {
                Console.WriteLine($"Turn number {counter}");
                hurt = counterRoleAttacks.Next(1, 6);
                monsterHealth = monsterHealth - hurt;
                Console.WriteLine("Hero attacks.");
                Console.WriteLine($"Hero hits and inflicts {hurt} of hurt!");
                Console.WriteLine($"Monster's health is {monsterHealth}.");
                counter++;
                if (monsterHealth > 0)
                {
                    Console.WriteLine($"Turn number {counter}");
                    hurt = counterRoleAttacks.Next(1, 6);
                    heroHealth = heroHealth - hurt;
                    Console.WriteLine("Monster attacks");
                    Console.WriteLine($"Monster hits and inflicts {hurt} of hurt!");
                    if (heroHealth > 0) {Console.WriteLine($"Hero is {heroHealth} health left.");}
                    counter++;
                }

                if (monsterHealth <= 0)
                {
                    Console.WriteLine("Monster died. HERO WINS!!");
                }

                if (heroHealth <= 0)
                {
                    Console.WriteLine("Hero died. MONSTER WINS!!");
                }

                if (heroHealth <= 0 || monsterHealth <= 0)
                {
                    counterRoleMaster = false;
                }
            }
        }
    }
}

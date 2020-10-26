using System;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Harry Potter", "Luke Skywalker", "Batman", "Elastic girl", "Thor" };
            string[] villians = { "Voldemort", "Darth Vader", "Sauron", "Joker", "Thanos" };

            string hero = GetCharacter(heroes);
            string villian = GetCharacter(villians);
            Console.WriteLine($"{hero} will fight {villian}");

            Random rnd = new Random();
            int HeroHP = rnd.Next(5, 11);
            int VillianHP = rnd.Next(5, 11);

            int heroHp = GenerateHP();
            int villianHP = GenerateHP();
            Console.WriteLine($"{hero} with {heroHp} HP will fight {villian}with " + $"{villianHP} HP");

            while (heroHp > 0 && villianHP > 0)
            {
                
                HeroHP = heroHp - rnd.Next(0, 4);
                villianHP = villianHP - rnd.Next(0, 4);
            }

            
        }
        public static string GetCharacter(string[] array)
        {
            Random rnd = new Random();
            string randomString = array[rnd.Next(0, array.Length)];
            return randomString;

        }

        public static int GenerateHP()
        {
            Random rnd = new Random();
            int HP = rnd.Next(5, 11);
            return HP;
        }
        public static int hit(string character)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, 4);
            Console.WriteLine($"{character} hit {strike}");
            if (strike == 3)
            {
                Console.WriteLine($"Awesome! {character}made a critical hit");

            }
            else if (strike == 0)
            {
                Console.WriteLine($"Bad luck! {character} missed the target!");

            }
            return strike;
        }

    }
}

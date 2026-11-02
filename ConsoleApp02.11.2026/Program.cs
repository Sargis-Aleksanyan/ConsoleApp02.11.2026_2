namespace ConsoleApp02._11._2026
{
    public class Bonus
    {
        public int bonus = 5;
    }

    public class Level
    {
        public Bonus bonus;
        public int level;
        
        public int Calculate(int n)
        {
            int x = n + level + bonus.bonus;
            return x;
        }
    }

    internal class Program
    {
        delegate int Mix(int n);
        static Mix[] Build()
        {
            Bonus bonus = new Bonus();
            bonus.bonus = 5;
            Mix[] rows = new Mix[3];
            for (int i = 0; i < 3; i++)
            {
                Level level = new Level();
                level.level = i;
                level.bonus = bonus;
                rows[i] = level.Calculate;

            }
            bonus.bonus = 50;
            return rows;
        }

        static void Main(string[] args)
        {
            Mix[] rows = Build();

            Console.WriteLine(rows[0](2)); 
            Console.WriteLine(rows[1](2)); 
            Console.WriteLine(rows[2](2)); 
            Console.WriteLine(rows[0](0));
        }
    }
}

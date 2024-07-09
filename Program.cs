namespace g1
{
    #region Q1
    public enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    class prog1
    {
        static void Main(String[] args)
        {
            for (int i = 0; i < 7; i++)
            {
                WeekDays day = (WeekDays)i;
                Console.WriteLine(day);
            }
        }
    }

    #endregion


    #region Q2
    public enum Season
    {
        Spring = 1, Summer = 2, Autumn = 3, Winter = 4
    }
    class prog2
    {
        static void Main(String[] args)
        {
            string s1 = Console.ReadLine();

            bool flag = Enum.TryParse<Season>(s1, true, out Season s);

            if (s == Season.Spring)
            {
                Console.WriteLine(" months is -> march , april , may ");
            }
            else if (s == Season.Summer)
            {
                Console.WriteLine(" months is -> June , July , August ");
            }
            else if (s == Season.Autumn)
            {
                Console.WriteLine(" months is -> September , October , November  ");
            }
            else if (s == Season.Winter)
            {
                Console.WriteLine(" months is -> December , January , February ");
            }

        }
    }

    #endregion




    #region Q3
    public enum WeekDays
    {

    }
    class prog3
    {
        static void Main(String[] args)
        {

        }
    }

    #endregion



    #region Q4
    public enum colors
    {
        Red, Green, Blue
    }
    class prog4
    {
        static void Main(String[] args)
        {
            string color = Console.ReadLine();
            Enum.TryParse<colors>(color, true, out colors c1);
            if (c1 == colors.Red || c1 == colors.Blue || c1 == colors.Green)
            {
                Console.WriteLine("color is prime");
            }
            else
            {
                Console.WriteLine("color is not prime");
            }
        }
    }

    #endregion

    #region Q6
    internal struct point
    {

        public int x, y;
        public point(int s, int m)
        {
            x = 0;
        }
    }
    class prog6
    {
        static void Main(String[] args)
        {
            point p1;
            p1.x = int.Parse(Console.ReadLine());
            p1.y = int.Parse(Console.ReadLine());
            if (p1.x > p1.y)
            {
                Console.WriteLine($"DISTANCE = {p1.x - p1.y}");
            }
            else
            {
                Console.WriteLine($"DISTANCE = {p1.y - p1.x}");
            }
        }


    }

    #endregion

}
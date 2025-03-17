namespace PJT250317
{
    internal class Program
    {
        class HelloWorld
        {
            public HelloWorld(int inGold = 100, int inHP = 100, int inMP = 100)
            {
                Gold = inGold;
                MP = inMP;
                HP = inGold;
            }

            public int Gold;
            public int MP;
            public int HP;
        }
        static void Main(string[] args)
        {
            HelloWorld h = new HelloWorld(10, 20, 30);

            StreamReader sr = new StreamReader("/data.dat");
            string DataGold = sr.ReadLine();
            string DataHP = sr.ReadLine();
            string DataMP = sr.ReadLine();

            sr.Close();

        }
    }
}

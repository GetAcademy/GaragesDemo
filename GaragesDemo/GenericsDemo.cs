namespace GaragesDemo
{
    internal class GenericsDemo
    {
        public static void Run()
        {
            var txt = Add("A", "B");
            // "AB"
            var number = Add(3, 4);
            // 7

            var txt2 = Addx("A", "B");
            // "AB"
            var txt3 = Addx(3, 4);
            // "34"

        }

        static string Add(string a, string b)
        {
            return a + b;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static string Addx<T>(T a, T b)
        {
            return a.ToString() + b.ToString();
        }
    }
}

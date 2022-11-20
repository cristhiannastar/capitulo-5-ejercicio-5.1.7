namespace ejercicio51
{
    public class program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string[] units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
                string[] decs = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "XC" };
                string[] cents = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
                string[] mils = { "", "M", "MM", "MMM" };
                var value = Console.ReadLine();
                if (string.IsNullOrEmpty(value))
                    return;
                var N = int.Parse(value);
                if (N <= 0 || N >= 3999)
                {
                    Console.WriteLine("valor no permitido");
                    return;
                }
                int m = N / 1000;
                int resto = N % 1000;
                int c = resto / 100;
                resto = resto % 100;
                int d = resto / 10;
                resto = resto % 10;
                int u = resto;
                Console.WriteLine(mils.ElementAtOrDefault(m) + cents.ElementAtOrDefault(c) + decs.ElementAtOrDefault(d) + units.ElementAtOrDefault(u));
            }
        }
    }
}
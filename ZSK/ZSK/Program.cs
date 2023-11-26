using Domain.NewDirectory;

namespace ZSK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line = "";

            while (line != "0")
            {
                Console.WriteLine("Choose action:");
                Console.WriteLine("1. Normal number swap");
                Console.WriteLine("2. Magic number swap");
                Console.WriteLine("3. GCD iteration");
                Console.WriteLine("4. GCD recursive");
                Console.WriteLine("5. LZW compression");
                Console.WriteLine("6. LZW decompression");
                Console.WriteLine("0. Exit");
                line = Console.ReadLine();

                switch (line)
                {
                    case "1":
                        ExecuteNumberSwap();
                        break;
                    case "2":
                        ExecuteMagicNumberSwap();
                        break;
                    case "3":
                        ExecuteGCDiteration();
                        break;
                    case "4":
                        ExecuteGCDrecursion();
                        break;
                    case "5":
                        LZWCompression();
                        break;
                    case "6":
                        LZWDecompression();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("====================");
            }
        }

        static void GiveMeIntegers(out int x, out int y)
        {
            Console.WriteLine("Insert first number (int): ");
            var a = Console.ReadLine();
            Console.WriteLine("Insert second number (int): ");
            var b = Console.ReadLine();

            bool result1, result2;

            result1 = int.TryParse(a, out int xTMP);
            result2 = int.TryParse(b, out int yTMP);

            if (!(result1 && result2))
            {
                Console.WriteLine("int... INT... INTEGER...");
            }

            x = xTMP;
            y = yTMP;
        }

        static string GiveMeString()
        {
            Console.WriteLine("Insert string: ");
            string line = Console.ReadLine() ?? String.Empty;
            line = line.Trim();

            if (line == string.Empty || line == "")
            {
                Console.WriteLine("Why empty string?");
            }

            return line;
        }

        static void ExecuteNumberSwap()
        {
            GiveMeIntegers(out int x, out int y);

            NumberSwap.NormalVariableSwap(x, y, out int resultX, out int resultY);
            Console.WriteLine($"Your first number is {resultX} \t Your second number is: {resultY}");
        }

        static void ExecuteMagicNumberSwap()
        {
            GiveMeIntegers(out int x, out int y);
            NumberSwap.MagicVariableSwap(x, y, out int resultX, out int resultY);
            Console.WriteLine($"Your first number is {resultX} \t Your second number is: {resultY}");
        }

        static void ExecuteGCDiteration()
        {
            GiveMeIntegers(out int x, out int y);
            var result = GreatestCommonDivisor.GCDiterative(y, x);
            Console.WriteLine($"Result: {result}");
        }

        static void ExecuteGCDrecursion()
        {
            GiveMeIntegers(out int x, out int y);
            var result = GreatestCommonDivisor.GCDrecursive(y, x);
            Console.WriteLine($"Result: {result}");
        }

        static void LZWCompression()
        {
            var str = GiveMeString();

            var result = LZW.Compress(str);

            Console.WriteLine(String.Join(",", result));
        }

        static void LZWDecompression()
        {
            var str = GiveMeString();
            var asd = str.Split(new char[] { ',' }).ToList();
            List<int> res = new();
            asd.ForEach(x => res.Add(int.Parse(x)));

            var result = LZW.Decompress(res);
            Console.WriteLine(result);
        }
    }
}

namespace PR333
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Для выбора октав 4 и 5 нажимайте клавиши F4 и F5 соответственно номеру октавы\n");
            Sound();
        }
        private static ConsoleKeyInfo PK()
        {
            return Console.ReadKey(true);
        }
        private static int[] Octava(int n)
        {
            switch (n)
            {
                case 0:
                    Console.WriteLine("4-я октава\n");
                    return new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                case 1:
                    Console.WriteLine("5-я октава\n");
                    return new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                default: return new int[] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
            }
        }
        private static void Sound()
        {
            int[] hz = Octava(4);
            ConsoleKeyInfo i = PK();
            Console.WriteLine("Для проигрывания звука используйте клавиши W -> U и A -> H\n");
            while (true)
            {
                switch (i.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(hz[0], 500);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(hz[1], 500);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(hz[2], 500);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(hz[3], 500);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(hz[4], 500);
                        break;
                    case ConsoleKey.R:
                        Console.Beep(hz[5], 500);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(hz[6], 500);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(hz[7], 500);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(hz[8], 500);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(hz[9], 500);
                        break;
                    case ConsoleKey.H:
                        Console.Beep(hz[10], 500);
                        break;
                    case ConsoleKey.U:
                        Console.Beep(hz[11], 500);
                        break;
                    case ConsoleKey.F4:
                        hz = Octava(0);
                        break;
                    case ConsoleKey.F5:
                        hz = Octava(1);
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
                i = PK();
            }
        }
    }
}
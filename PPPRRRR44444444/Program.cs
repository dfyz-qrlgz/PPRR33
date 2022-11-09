namespace PPPRRRR44444444
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sheet();
        }
        static void Sheet()
        {
            int page = 0;
            int arrowPosition = 1;

            Sheet fday = new Sheet()
            {
                date = new DateTime(2022, 11, 11),
                notes = new string[] { "Зарядка", "Учёба" }
            };

            Sheet sday = new Sheet()
            {
                date = new DateTime(2022, 11, 12),
                notes = new string[] { "Выполнить практические", "Письмо", "Ещё что-нибудь сделать" }
            };

            Sheet tday = new Sheet()
            {
                date = new DateTime(2022, 12, 25),
                notes = new string[] { "Кактус", "Бутерброд" }
            };

            Console.SetCursorPosition(0, arrowPosition);
            showSheet(fday);
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                        arrowPosition = 1;
                        if (page == 0)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showSheet(sday);
                            page++;
                        }
                        else if (page == 1)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showSheet(tday);
                            page++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        arrowPosition = 1;
                        if (page == 2)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showSheet(sday);
                            page--;
                        }
                        else if (page == 1)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showSheet(fday);
                            page--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (key.Key == ConsoleKey.DownArrow && page == 0)
                        {
                            arrowPosition++;
                            if (arrowPosition > 4)
                            {
                                arrowPosition--;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showSheet(fday);
                        }
                        else if (key.Key == ConsoleKey.DownArrow && page == 1)
                        {
                            arrowPosition++;
                            if (arrowPosition > 5)
                            {
                                arrowPosition--;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showSheet(sday);
                        }
                        else if (key.Key == ConsoleKey.DownArrow && page == 2)
                        {
                            arrowPosition++;
                            if (arrowPosition > 4)
                            {
                                arrowPosition--;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showSheet(tday);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (key.Key == ConsoleKey.UpArrow && page == 0)
                        {
                            arrowPosition--;
                            if (arrowPosition < 1)
                            {
                                arrowPosition++;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showSheet(fday);
                        }
                        else if (key.Key == ConsoleKey.UpArrow && page == 1)
                        {
                            arrowPosition--;
                            if (arrowPosition < 1)
                            {
                                arrowPosition++;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showSheet(sday);
                        }
                        else if (key.Key == ConsoleKey.UpArrow && page == 2)
                        {
                            arrowPosition--;
                            if (arrowPosition < 1)
                            {
                                arrowPosition++;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showSheet(tday);
                        }
                        break;
                    case ConsoleKey.Enter:
                        switch (page)
                        {
                            case 0:
                                if (arrowPosition == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Выбарана дата: {fday.date}");
                                    Console.WriteLine("<-------------------------------------->");
                                    Console.WriteLine("взять с собой повербанк");
                                }
                                else if (arrowPosition == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Выбарана дата: {fday.date}");
                                    Console.WriteLine("<-------------------------------------->");
                                    Console.WriteLine("переписать конспекты");
                                }
                                break;
                            case 1:
                                if (arrowPosition == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Выбарана дата: {sday.date}");
                                    Console.WriteLine("<-------------------------------------->");
                                    Console.WriteLine("доделать практические оаип по питону и с#");
                                }
                                else if (arrowPosition == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Выбарана дата: {sday.date}");
                                    Console.WriteLine("<-------------------------------------->");
                                    Console.WriteLine("написать абсолютно бесполезное письмо несуществующим англоговорящим друзьям");
                                }
                                else if (arrowPosition == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Выбарана дата: {sday.date}");
                                    Console.WriteLine("<-------------------------------------->");
                                    Console.WriteLine("можно сделать что-то интересное, вылепить из глины огромную пепельницу я не знаю");
                                }
                                break;
                            case 2:
                                if (arrowPosition == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Выбарана дата: {tday.date}");
                                    Console.WriteLine("<-------------------------------------->");
                                    Console.WriteLine("полить кактус и вытащить из него все иголки чтобы не быковал");
                                }
                                else if (arrowPosition == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Выбарана дата: {tday.date}");
                                    Console.WriteLine("<-------------------------------------->");
                                    Console.WriteLine("с сыром\nс сыном\nс крымом\nс брынзой\nс крысой\nс кантемиром\nс магнитом\nс могильными иглами\n- а гвозди?\n- так вот же они");
                                }
                                break;
                        }
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void showSheet(Sheet currentSheet)
        {
            Console.WriteLine("->");
            Console.SetCursorPosition(3, 0);
            Console.WriteLine(currentSheet.date);
            Console.CursorVisible = false;

            int i = 1;
            foreach (string n in currentSheet.notes)
            {
                i++;
                Console.SetCursorPosition(3, i);
                Console.WriteLine(n);
            }
        }
    }
}
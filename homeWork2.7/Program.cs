using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homeWork2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ComandName = "1";
            const string ComandColourName = "2";
            const string ComandSymbol = "3";
            const string ComandColourSymbol = "4";
            const string ComandResult = "5";
            const string CommandExit = "6";
            const string ComandColourNameBlue = "синий";
            const string ComandColourNameYellow = "желтый";

            string disairedColor = "";
            string disairedSymbolColor = "";
            string desiredOperation = "";
            string name = "";
            string symbol = "";
            bool isCommandExit = true;

            Console.WriteLine("Добро пожаловать, здесь мы по попробуем написать имя, выбрать для него цвет, выбрать символ и цвет для него а затем вывести это все красиво)");
            Console.WriteLine($"{ComandName} - ввод имени ");
            Console.WriteLine($"{ComandColourName} - цвет имя ");
            Console.WriteLine($"{ComandSymbol} - ввод символа(Рамочки)");
            Console.WriteLine($"{ComandColourSymbol} - цвет символа(рамочки)");
            Console.WriteLine($"{ComandResult} - вывод имени в рамочке)");
            Console.WriteLine($"{CommandExit} - Выход");

            while (isCommandExit)
            {
                Console.WriteLine("Ваш выбор:  ");
                desiredOperation = Console.ReadLine();
                switch (desiredOperation)
                {
                    case ComandName:
                        Console.WriteLine("Введите ваше имя");
                        name = Console.ReadLine();
                        break;

                    case ComandColourName:
                        {
                            Console.WriteLine("Выберите цвет для имени");
                            Console.WriteLine($"{ComandColourNameBlue}");
                            Console.WriteLine($"{ComandColourNameYellow}");
                            string tempDisairedColor = Console.ReadLine();
                            if (tempDisairedColor != ComandColourNameBlue && tempDisairedColor != ComandColourNameYellow)
                            {
                                Console.WriteLine("нет такова");
                            }
                            else
                            {
                                disairedColor = tempDisairedColor;
                            }
                            break;
                        }
                    case ComandSymbol:
                        Console.WriteLine("Введите символ");
                        symbol = Console.ReadLine();
                        break;

                    case ComandColourSymbol:
                        {
                            Console.WriteLine("Выберите цвет символа");
                            Console.WriteLine($"{ComandColourNameBlue}");
                            Console.WriteLine($"{ComandColourNameYellow}");
                            string tempDisairedColor = Console.ReadLine();
                            if (tempDisairedColor != ComandColourNameBlue && tempDisairedColor != ComandColourNameYellow)
                            {
                                Console.WriteLine("нет такова");
                            }
                            else
                            {
                                disairedSymbolColor = tempDisairedColor;
                            }
                            break;
                        }
                    case ComandResult:
                        PrintResult(name, symbol, disairedColor, disairedSymbolColor);
                        break;
                    case CommandExit:
                        Console.WriteLine("Выход");
                        isCommandExit = false;
                        break;
                }
            }
        }

        static void PrintColorText(string text, string color)
        {
            if (color == "желтый")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            if (color == "синий")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write(text);
            Console.ResetColor();
        }
        static void PrintResult(string name, string symbol, string textColor, string symbolColor)
        {
            int numberSymbols = name.Length + 2;
            for (int i = 0; i < numberSymbols; i++)
            {
                PrintColorText(symbol, symbolColor);
            }
            Console.WriteLine();
            PrintColorText(symbol, symbolColor);
            PrintColorText(name, textColor);
            PrintColorText(symbol, symbolColor);
            Console.WriteLine();
            for (int i = 0; i < numberSymbols; i++)
            {
                PrintColorText(symbol, symbolColor);
            }
            Console.WriteLine();
        }
    }
}

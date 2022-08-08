using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;

namespace CurrParser
{

    internal class Program
    {
        const string path = "https://www.cbr-xml-daily.ru/daily.xml";
        const string xml1 = "<Name>Австралийский доллар</Name><Value>(.*?)</Value>";
        const string xml2 = "<Name>Фунт стерлингов Соединенного королевства</Name><Value>(.*?)</Value>";
        const string xml3 = "<Name>Белорусский рубль</Name><Value>(.*?)</Value>";
        const string xml4 = "<Name>Датских крон</Name><Value>(.*?)</Value>";
        const string xml5 = "<Name>Доллар США</Name><Value>(.*?)</Value>";
        const string xml6 = "<Name>Евро</Name><Value>(.*?)</Value>";
        const string xml7 = "<Name>Индийских рупий</Name><Value>(.*?)</Value>";
        const string xml8 = "<Name>Казахстанских тенге</Name><Value>(.*?)</Value>";
        const string xml9 = "<Name>Канадский доллар</Name><Value>(.*?)</Value>";
        const string xml10 = "<Name>Норвежских крон</Name><Value>(.*?)</Value>";
        const string xml11 = "<Name>Сингапурский доллар</Name><Value>(.*?)</Value>";
        const string xml12 = "<Name>Турецких лир</Name><Value>(.*?)</Value>";
        const string xml13 = "<Name>Украинских гривен</Name><Value>(.*?)</Value>";
        const string xml14 = "<Name>Шведских крон</Name><Value>(.*?)</Value>";
        const string xml15 = "<Name>Швейцарский франк</Name><Value>(.*?)</Value>";
        const string xml16 = "<Name>Японских иен</Name><Value>(.*?)</Value>";

        static void Menu()
        {
            string line = null;
            uint input;
            Console.WriteLine("\t\t\t\tМеню:\n\n");

            Console.WriteLine("1 - курс русского рубля к Австралийскому Доллару");
            Console.WriteLine("2 - курс русского рубля к Фунту Стрелингов Соедененного Королевства");
            Console.WriteLine("3 - курс русского рубля к Белорускому Рублю");
            Console.WriteLine("4 - курс русского рубля к Датскому Крону");
            Console.WriteLine("5 - курс русского рубля к Доллару США");
            Console.WriteLine("6 - курс русского рубля к Евро");
            Console.WriteLine("7 - курс русского рубля к Индийскому рупию");
            Console.WriteLine("8 - курс русского рубля к Казахстанскому Тенге");
            Console.WriteLine("9 - курс русского рубля к Канадскому Доллару");
            Console.WriteLine("10 - курс русского рубля к Норвежскому Крону");
            Console.WriteLine("11 - курс русского рубля к Сингапурскому Доллару");
            Console.WriteLine("12 - курс русского рубля к Турецкой Лире");
            Console.WriteLine("13 - курс русского рубля к Украинской Гривне");
            Console.WriteLine("14 - курс русского рубля к Шведскому Крону");
            Console.WriteLine("15 - курс русского рубля к Швейцарскому Франку");
            Console.WriteLine("16 - курс русского рубля к Японской Йене");

            Console.Write("\nВвод ");
            while (!uint.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Ошибка ввода");
            }
            Console.Clear();
            switch (input)
            {
                case 1:
                    Console.WriteLine("Курс русского рубля к Австралийскому доллару составляет: " + GetCurr(line, xml1));
                    BackOrExit();
                    break;
                case 2:
                    Console.WriteLine("Курс русского рубля к Фунту Стрелингов Соедененного королевства составляет: " + GetCurr(line, xml2));
                    BackOrExit();
                    break;
                case 3:
                    Console.WriteLine("Курс русского рубля к Белорускому рублю составляет: " + GetCurr(line, xml3));
                    BackOrExit();
                    break;
                case 4:
                    Console.WriteLine("Курс русского рубля к Датскому крону составляет: " + GetCurr(line, xml4));
                    BackOrExit();
                    break;
                case 5:
                    Console.WriteLine("Курс русского рубля к Доллару США составляет: " + GetCurr(line, xml5));
                    BackOrExit();
                    break;
                case 6:
                    Console.WriteLine("Курс русского рубля к Евро составляет: " + GetCurr(line, xml6));
                    BackOrExit();
                    break;
                case 7:
                    Console.WriteLine("Курс русского рубля к Индийскому рупию составляет: " + GetCurr(line, xml7));
                    BackOrExit();
                    break;
                case 8:
                    Console.WriteLine("Курс русского рубля к Казахстанскому тенге составляет: " + GetCurr(line, xml8));
                    BackOrExit();
                    break;
                case 9:
                    Console.WriteLine("Курс русского рубля к Канадскому доллару составляет: " + GetCurr(line, xml9));
                    BackOrExit();
                    break;
                case 10:
                    Console.WriteLine("Курс русского рубля к Норвежскому крону составляет: " + GetCurr(line, xml10));
                    BackOrExit();
                    break;
                case 11:
                    Console.WriteLine("Курс русского рубля к Сингапурскому доллару составляет: " + GetCurr(line, xml11));
                    BackOrExit();
                    break;
                case 12:
                    Console.WriteLine("Курс русского рубля к Турецкой лире составляет: " + GetCurr(line, xml12));
                    BackOrExit();
                    break;
                case 13:
                    Console.WriteLine("Курс русского рубля к Украинской гривне составляет: " + GetCurr(line, xml13));
                    BackOrExit();
                    break;
                case 14:
                    Console.WriteLine("Курс русского рубля к Шведскому крону составляет: " + GetCurr(line, xml14));
                    BackOrExit();
                    break;
                case 15:
                    Console.WriteLine("Курс русского рубля к Швейцарскому франку составляет: " + GetCurr(line, xml15));
                    BackOrExit();
                    break;
                case 16:
                    Console.WriteLine("Курс русского рубля к Японской йене составляет: " + GetCurr(line, xml16));
                    BackOrExit();
                    break;
                default:
                    Console.WriteLine("Не верный ввод");
                    break;
            }
        }
        static string GetCurr(string str, string xml)
        {
            using (WebClient wc = new WebClient())
            {
                str = wc.DownloadString("https://www.cbr-xml-daily.ru/daily.xml");
                Match match = Regex.Match(str, xml);
                return match.Groups[1].Value;
            }
        }
        static void BackOrExit()
        {
            uint selection;
            do
            {
                Console.WriteLine("\n\n1 - Вернуться в меню\n2 - Выход из программы");

                while (!uint.TryParse(Console.ReadLine(), out selection))
                {
                    Console.WriteLine("Ошибка ввода, попробуйте еще раз.");
                }
                Console.Clear();
                switch (selection)
                {
                    case 1:
                        Menu();
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                }
            } while (selection != 2);
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}

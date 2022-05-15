using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_Currency_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double balanceEuro = 100;
            double balanceRub = 100;
            double balanceUsd = 100;
            Console.WriteLine($"Ваш баланс: \nЕвро: {balanceEuro} \nРубли: {balanceRub} \nДоллары: {balanceUsd}\n");

            string neededConversion = "";
            double numberEuroCurrency;
            double numberRubCurrency;
            double numberUsdCurrency;

            while (neededConversion != "Выход")
            {
                Console.WriteLine("Что необходимо конвертировать ?");
                neededConversion = Console.ReadLine();

                switch (neededConversion)
                {
                    case "Евро в рубли":
                        Console.WriteLine("Введите сумму для конвертации");
                        numberEuroCurrency = double.Parse(Console.ReadLine());
                        double numberRublesForEuro = 80;
                        balanceEuro -= numberEuroCurrency;
                        balanceRub += numberEuroCurrency * numberRublesForEuro;
                        break;

                    case "Евро в доллары":
                        Console.WriteLine("Введите сумму для конвертации");
                        numberEuroCurrency = double.Parse(Console.ReadLine());
                        double courseUsdForEuro = 1;
                        balanceEuro -= numberEuroCurrency;
                        balanceUsd += numberEuroCurrency * courseUsdForEuro;
                        break;

                    case "Рубли в евро":
                        Console.WriteLine("Введите сумму для конвертации");
                        numberRubCurrency = double.Parse(Console.ReadLine());
                        double courseEuroForRub = 0.015;
                        balanceRub -= numberRubCurrency;
                        balanceEuro += numberRubCurrency * courseEuroForRub;
                        break;

                    case "Рубли в доллары":
                        Console.WriteLine("Введите сумму для конвертации");
                        numberRubCurrency = double.Parse(Console.ReadLine());
                        double courseUsdForRub = 0.016;
                        balanceRub -= numberRubCurrency;
                        balanceUsd += numberRubCurrency * courseUsdForRub;
                        break;

                    case "Доллары в рубли":
                        Console.WriteLine("Введите сумму для конвертации");
                        numberUsdCurrency = double.Parse(Console.ReadLine());
                        double courseRubForUsd = 65;
                        balanceUsd -= numberUsdCurrency;
                        balanceRub += numberUsdCurrency * courseRubForUsd;
                        break;

                    case "Доллары в евро":
                        Console.WriteLine("Введите сумму для конвертации");
                        numberUsdCurrency = double.Parse(Console.ReadLine());
                        double courseEuroForUsd = 1;
                        balanceUsd -= numberUsdCurrency;
                        balanceEuro += numberUsdCurrency * courseEuroForUsd;
                        break;
                    default:
                        Console.WriteLine("Непонятный запрос\n");
                        break;
                }

                Console.WriteLine($"Ваш баланс: \nЕвро: {balanceEuro} \nРубли: {balanceRub} \nДоллары: {balanceUsd}\n");
            }    
            
            
        }
    }
}

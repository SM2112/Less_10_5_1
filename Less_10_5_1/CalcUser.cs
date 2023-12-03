using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_10_5_1
{

    // описываем интерфейс
    public interface ICalc
    {
        // закладываем метод, который будет реализован в дочернем классе
        // это надо по заданию 1
        public void SumCalc();
       
    }


    public class CalcUser : ICalc
    {
        // свойство класса
        ILogger Logger { get; }

        // конструктор для класса
        public CalcUser(ILogger logger)
        {
            Logger = logger;
        }

        public void SumCalc()
        {
            try // блок try будет работать для всего кода. Таким образом он будет проверять оба ввведенных значения
            {
                // вписываем логгер
                Logger.Event("Мы в калькуляторе. Это пишет Logger!");
                // переменные класса
                int term1, term2;
                int result;

                Console.WriteLine();
                Console.WriteLine("Вы находитесь в калькуляторе!");
                Console.WriteLine("Калькулятор создан для сложения двух целых чисел!");

                Console.Write("Введите слагаемое 1: ");
                term1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите слагаемое 1: ");
                term2 = Convert.ToInt32(Console.ReadLine());

                // собственно сложение
                result = term1 + term2;

                Console.WriteLine("Результат сложения: {0}", result);
                Console.WriteLine("Калькулятор отработал!");
                Logger.Event("Мы выходим из калькулятора. Это пишет Logger!");

            }

            catch (Exception e)
            {
                Logger.Error("Логгер сообщает об ошибке!");
                Console.WriteLine("Произошла ошибка!");
                Console.WriteLine(e.GetType());
                Console.WriteLine("Возможно Вы ввели значение слагаемого, которое невозможно конвертировать в тип Int!");
                Logger.Error("Логгер закончил сообщать об ошибке!");
                Console.WriteLine();
            }
            
            
        }

    }
}

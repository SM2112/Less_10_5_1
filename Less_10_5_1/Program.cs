namespace Less_10_5_1
{
    internal class Program
    {
        static ILogger Logger { get; set; }
        
        static void Main(string[] args)
        {
            Console.WriteLine("===================================================================");
            Console.WriteLine("ЗАДАНИЕ 1 И 2"); 

            string answerUser;
            Console.WriteLine();
            Console.WriteLine("Проверка задания 1");
            Console.WriteLine("Вы  хотите запустить калькулятор?");
            Console.Write("Введите ДА или нажмите любую клавишу для закрытия программы: ");

            answerUser = Console.ReadLine();

            if (answerUser == "ДА")
            {
                Logger = new Logger();
                CalcUser calcUser = new CalcUser(Logger);
                calcUser.SumCalc();
            }
            else
            {
                Console.WriteLine("Вы решили не тестировать калькулятор! Программа будет закрыта!");
                Console.WriteLine("СПАСИБО!");
            }

            Console.WriteLine("ОКОНЧАНИЕ ЗАДАНИЯ 1 И 2");
            Console.WriteLine("===================================================================");
        }
    }
}
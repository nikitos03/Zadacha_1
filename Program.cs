using System;

namespace ЕНГ_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в магазин");

            Console.WriteLine("Введите начальное кол-во золота: ");
            int gold;
            gold = Convert.ToInt32(Console.ReadLine());

            int sum = 100;
            Console.WriteLine("Вы можете купить " + gold / sum + " кристалла(ов) по цене " + sum + " за штуку");
            
            Console.WriteLine("Пердлагаем Вам купить кристаллы, введите кол-во кристаллов которое хотите купить: ");

            int crystal;
            crystal = Convert.ToInt32(Console.ReadLine());

            if(crystal * 2 > gold)
            {
                Console.WriteLine("У Вас мало золота");
            }
            else
            {
                int crystal1 = crystal * sum;

                Console.WriteLine("Вы купили " + crystal + " кристалла(ов), у Вас осталось " + (gold - crystal1) + " золота.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOnellect
{
    internal class Program
    {
        public static int[] array;
        public static int elemCount,choose;
        public static Random random = new Random();
        

        static void Main(string[] args)
        {

            RandArray();
           
            
           
        }
        


        


        static public void RandArray() /// метод для составления массива
        {
           

            elemCount = random.Next(20, 100);

            

            array = new int[elemCount];

            for (int i = 0; i< elemCount;i++)
            {
                

                array[i] = random.Next(-100, 100) ;

               
            }

            Output(array, elemCount);
           

        }


        static void ChooseSort()
        {

            choose = random.Next(1,3);
           
           if (choose == 1) /// выбор коктейльной сортировки
            {
                Console.WriteLine("Выбрана сортировка Коктейль!");
                Output(CockTailSort.Sort(array), elemCount);
                

            }
           else if (choose == 2) /// выбор гномьей сортировки
            {
                Console.WriteLine("Выбрана сортировка Гномья (обратная) !");
                Output(GnomeSort.Sort(array),elemCount);
                


            }

          
           


        }


        public static void Swap(int[] myint, int i, int j) /// метод для смены положения элементов массива
        {
            int glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
        }



        public static async void Output(int[] arrayToOutput,int count) /// метод вывода массива в консоль
        {
            string arrvalue = "";


           
            for(int i = 0; i < arrayToOutput.Length; i++) arrvalue += $" {arrayToOutput[i]}";

            
            Console.WriteLine($"Массив: {arrvalue} \nКоличество элементов массива = {count}");
            Console.WriteLine("Для повторной сортировки нажмите R, для выхода любую клавишу");

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.R)
            {
                ChooseSort();


            }
           
            else
            {
                await PostArray.Post(arrvalue);
            }
           

        }
    }
}

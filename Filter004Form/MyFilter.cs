using Filter004Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter004
{

    internal class MyFilter
    {

        public int AmountOfArray11(int[] array) // Подсчитать сумму чётных элементов массива, меньших -10 или больших 10
        {

            int result = 0;
            foreach (var item in array)
            {
                if (item < (-10) || item > 10)
                {
                    result += item;
                }
            }
            //Console.WriteLine(result);
            return result;
        }
        public string NumbersOfArray11(int[] array)
        {
            string result = string.Empty;

            foreach (var item in array)
            {
                if (item < (-10) || item > 10)
                {
                    result += item + " ";
                }
            }

            return result + '\n' + '\r';
        }
        public int AmountOfArray1(int[] array) //Подсчитать сумму чётных элементов массива, делящихся нацело на 3.
        {
            int result = 0;
            int[] honest = Arrey.EvenElements(array);
            foreach (var item in honest)
            {
                if (item % 3 == 0)
                {
                    result += item;
                }
            }

            return result;
        }
        public string NumbersOfArray1(int[] array)
        {
            string result = string.Empty;

            int[] honest = Arrey.EvenElements(array);
            foreach (var item in honest)
            {
                if (item % 3 == 0)
                {
                    result += item + " ";
                }
            }
            return result + '\n' + '\r';
        }

        public int AmountOfArray2(int[] array) // Подсчитать сумму нечётных элементов массива, начинающихся на 3.
        {
            int result = 0;
            int[] notEven = Arrey.OddElements(array);
            foreach (int item in notEven)
            {
                int tmp = item;
                if (tmp == 3)
                {
                    result += item;
                }

                while (tmp > 10)
                {
                   tmp = tmp / 10;
                    if (tmp < 10 && tmp == 3)
                    {
                        
                            result += item;
                        
                    }
                }

            }
            return result;
        }
        public string NumbersOfArray2(int[] array)
        {
            string result = string.Empty;
            int[] notEven = Arrey.OddElements(array);
            foreach (int item in notEven)
            {
                int tmp = item;
                if (tmp == 3)
                {
                    result += item + " ";
                }

                while (tmp > 10)
                {
                    tmp = tmp / 10;
                    if (tmp < 10 && tmp == 3)
                    {

                        result += item + " ";

                    }
                }

            }
           
            return result + '\n' + '\r';

        }

        public int AmountOfArray3(int[] array) //Подсчитать сумму чётных элементов массива, кратных 7.
        {
            int result = 0;
            int[] honest = Arrey.EvenElements(array);
            foreach (var item in honest)
            {
                if (item % 7 == 0)
                {
                    result += item;
                }
            }

            return result;
        }
        public string NumbersOfArray3(int[] array)
        {
            string result = string.Empty;

            int[] honest = Arrey.EvenElements(array);
            foreach (var item in honest)
            {
                if (item % 7 == 0)
                {
                    result += item + " ";
                }
            }
            return result + '\n' + '\r';
        }
        public int AmountOfArray4(int[] array) // Подсчитать сумму нечётных элементов массива, меньших -1.
        {
            int result = 0;
            int[] notEven = Arrey.OddElements(array);
            foreach (var item in notEven)
            {
                if (item < (-1) )
                {
                    result += item;
                }
            }

            return result;
        }
        public string NumbersOfArray4(int[] array)
        {
            string result = string.Empty;
            int[] notEven = Arrey.OddElements(array);

            foreach (var item in notEven)
            {
                if (item < (-1) )
                {
                    result += item + " ";
                }
            }

            return result + '\n' + '\r';
        }
        public int AmountOfArray5(int[] array) //Подсчитать сумму нечётных элементов массива, делящихся нацело на 11.
        {
            int result = 0;
            int[] notEven = Arrey.OddElements(array);
            foreach (var item in notEven)
            {
                if (item % 11 == 0)
                {
                    result += item;
                }
            }

            return result;
        }
        public string NumbersOfArray5(int[] array)
        {
            string result = string.Empty;
            int[] notEven = Arrey.OddElements(array);

            foreach (var item in notEven)
            {
                if (item % 11 == 0)
                {
                    result += item + " ";
                }
            }

            return result + '\n' + '\r';
        }
    }
}

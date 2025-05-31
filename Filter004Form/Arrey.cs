using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter004Form
{
    internal class Arrey
    {
        public static int[] StringToArrey(string text) // преобразует строку в массив инт
        {
            List<int> result = new List<int>();
            int tmp = 0;
            foreach (var item in text.Split(' '))
            {
                if (int.TryParse(item,out tmp))
                { 
                    result.Add(tmp);
                }
            }
            
            return result.ToArray();
        }
        public static int[] EvenElements(int[] arr ) // четные елементы массива
        {
            List<int> result = new List<int>();
            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }

        public static int[] OddElements(int[] arr) //НЕ четные елементы массива
        {
            List<int> result = new List<int>();
            foreach (var item in arr)
            {
                if (item % 2 != 0)
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }
    }
}


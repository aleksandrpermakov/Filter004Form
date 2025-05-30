using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter004Form
{
    internal class Arrey
    {
        public static int[] StringToArrey(string text) 
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
    }
}

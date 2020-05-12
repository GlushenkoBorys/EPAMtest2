using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAMtest2
{//2 - вводится строка, в которой вместо пробелов тирэ.
    //Нужно что бы программа убирала эти тирэ и каждое новое слово начиналось с большой буквы
 //   Пример: В-городе-началась-весна ( ВГородеНачаласьВесна)
    class Program
    {
        static void Main(string[] args)
        {
            string mystr = Resolve("В-городе-началась-весна");
            Console.WriteLine(mystr);
            Console.ReadLine();
        }
        public static string Resolve(string arg) 
        {
            
            string result = "";
            char[] arr = arg.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]=='-')
                {
                    result+=arr[i+1].ToString().ToUpper();
                    i++;
                }
                else
                {
                    result += arr[i];
                }
            }

            return result;
        }
    }
}

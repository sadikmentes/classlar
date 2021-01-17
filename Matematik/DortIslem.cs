using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;


            Console.WriteLine("toplamları : "+ toplam);

            
        }
        public void carp(int sayi1 , int sayi2)
        {
            sayi1 = Convert.ToInt32(Console.ReadLine());

            int carpım = sayi1 + sayi2;

        }


    }
}

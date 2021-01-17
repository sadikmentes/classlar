using System;

namespace classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmeni = "engin demiroğ";
            kurs1.İzlenmeOrani =  45 ;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmeni = "Mustafa bige";
            kurs2.İzlenmeOrani = 75;

            Kurs kurs3= new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmeni = "sadık demir";
            kurs3.İzlenmeOrani = 55;

            //  Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar) 
            {  
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni); 
            }


        }
        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmeni { get; set; }
            public int İzlenmeOrani  { get; set; }





        }



    }
}

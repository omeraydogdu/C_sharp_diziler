using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramlamaTemelleri
{
    public class Diziler
    {
        public static void DiziCalistir()
        {
            // string msg = "Hello There. My name is Abdullah Akyol";
            // Console.WriteLine(msg[0]);
            // Console.WriteLine(msg[1]);
            // Console.WriteLine(msg[2]);
            // Console.WriteLine(msg[3]);
            // Console.WriteLine(msg[4]);

            // var result = msg.Split();
            // Console.WriteLine(result[0]);
            // Console.WriteLine(result[1]);
            // Console.WriteLine(result[2]);
            // Console.WriteLine(result[3]);
            // Console.WriteLine(result[4]);
            // Console.WriteLine(result[5]);
            // Console.WriteLine(result[6]);


            // string[] isimler = new string[5];
            string[] isimler = { "Ahmet", "Çınar", "Ada", "Yiğit", "Sena" };

            isimler[0] = "Ali";
            // isimler[1] = "Çınar";
            // isimler[2] = "Ada";
            // isimler[3] = "Yiğit";
            // isimler[4] = "Sena";

            // int[] numaralar = new int[5];
            int[] numaralar = { 101, 102, 103, 104, 105 };

            numaralar[0] = 100;
            // numaralar[1] = 102;
            // numaralar[2] = 103;
            // numaralar[3] = 104;
            // numaralar[4] = 105;

            Console.WriteLine($"öğrenci adı: {isimler[0]} ve numara: {numaralar[0]}");
            Console.WriteLine($"öğrenci adı: {isimler[1]} ve numara: {numaralar[1]}");
            Console.WriteLine($"öğrenci adı: {isimler[2]} ve numara: {numaralar[2]}");
            Console.WriteLine($"öğrenci adı: {isimler[3]} ve numara: {numaralar[3]}");
            Console.WriteLine($"öğrenci adı: {isimler[4]} ve numara: {numaralar[4]}");
        }
        public static void MetotCalisti()
        {
            // string[] isimler = {"Ahmet","Çınar","Ada","Yiğit","Sena"};
            // int[] numaralar = {5,3,6,1,2};

            // isimler[0] = "Ali";
            // isimler.SetValue("Ali",0);

            // Console.WriteLine(isimler.GetValue(0));
            // Console.WriteLine(Array.IndexOf(isimler,"Çınar"));
            // Console.WriteLine(isimler.Length);

            // Array.Sort(isimler);
            // Array.Sort(numaralar);

            // Array.Reverse(isimler);
            // Array.Reverse(numaralar);

            // Array.Clear(isimler,0,2);
            // Array.Clear(numaralar,0,2);

            // Console.WriteLine(isimler.GetValue(0));
            // Console.WriteLine(numaralar.GetValue(0));

            string[] isimler = { "Ahmet", "Çınar", "Ada", "Yiğit", "Sena" };
            var Apo = Array.FindAll(isimler, x => x.StartsWith("a", StringComparison.CurrentCultureIgnoreCase));
            foreach (var item in Apo)
            {
                Console.WriteLine(item);
            }
            Array.ForEach(isimler, x => { Console.WriteLine(x); });

            string msg = "Hello There";
            Console.WriteLine(msg[0]);
        }
    }
}

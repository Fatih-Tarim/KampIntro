using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici kamp kursu";
            string kurs2 = "programlamaya başlangıç kursu";
            string kurs3 = "Java kursu";

            string[] kurslar = new string[] { "Yazılım geliştirici kamp kursu", "programlamaya başlangıç kursu" , "Java kursu" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu | Footer");
        }
    }
}

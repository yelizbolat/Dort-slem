using System;

namespace toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("1.sayiyi giriniz :  ");
            double s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2.sayiyi giriniz :  ");
            double s2 = Convert.ToInt32(Console.ReadLine());

            DortIslem dortIslem = new DortIslem();
            Console.WriteLine("toplam : " + dortIslem.Topla(s1, s2));
            Console.WriteLine("cikartma : " + dortIslem.Cikart(s1, s2));
            Console.WriteLine("carrpma : " + dortIslem.Carp(s1, s2));
            Console.WriteLine("bolme : " + dortIslem.Bol(s1, s2));

        }
    }
    public class DortIslem
    {

        public double Topla(double s1, double s2)
        {
            return (s1 + s2);
        }
        public double Cikart(double s1, double s2)
        {
            return (s1 - s2);
        }
        public double Carp(double s1, double s2)
        {
            return (s1 * s2);
        }
        public double Bol(double s1, double s2)
        {
            return (s1 / s2);
        }
    }
}

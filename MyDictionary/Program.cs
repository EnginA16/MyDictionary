using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();
            isimler.Add("Halil");
            isimler.Add("Engin");
            isimler.Add("Burak");
            isimler.Add("Talha");
        }
    }
}

using System;
using System.Reflection;
using Sample.src;
using Xunit;
//using Nunit;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(3, 5);
            Assert.True(8 != 7);
            Assert.Equal("abc", "shzz");
            //Console.WriteLine("Bill total:\t{ 0,8:c}", 257);
            MyString s1 = new MyString("str1");
            MyString s2 = new MyString("str2");
            string s = " shzz";

            // test Up method
            Console.WriteLine(s1.Up());

            string s2up = s2.Up();
            Console.WriteLine(s2up);

            string[] splits = s1.Split();
            foreach (string sp in splits)
                Console.WriteLine(sp);

            Console.WriteLine(
                s1.Concat(s, 3)
                );
        }
    }
}

using System;
namespace Sample.src
{
    class MyString
    {  
        private string s = "MyString: ";
        public MyString(string str)
        {
            this.s = this.s + str;
            Console.WriteLine("Init MyString" +
                "!!!");
        }

        public string[] Split()
        {
            return this.s.Split(':'); 
        }

        public string Up()
        {
            return 
                this.s.ToUpper();
        }

        public string Concat(string s, int n)
        {
            for (int i = 0; i < n; ++i)
            {
                this.s =
                    String.Concat(
                    this.s, s
                    );
            }
            return this.s;   
        }
    }
}

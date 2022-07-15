using System;
using System.Text;

namespace 네트워크_프로그래밍_베이직_basic
{
    /* StringBuilder Class
       오버헤드의 부담 없이 새로운 스트림을 생성하고 수정할 수 있도록 만들어진 클래스이다.
     */ 
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("test string");
            int length = 0;

            length = sb.Length;
            Console.WriteLine("The result is: '{0}'", sb);
            Console.WriteLine("The length is: {0}", length);

            sb.Length = 4;
            length = sb.Length;
            // test
            Console.WriteLine("The result is: '{0}'", sb);
            Console.WriteLine("The result is: '{0}'", length);
        }
    }
}

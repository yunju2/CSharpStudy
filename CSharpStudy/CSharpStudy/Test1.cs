using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    interface setObject
    {
        string Print();
    }

    class Test1 
    { 
        class MyObject : setObject {

            string Object;
         public MyObject(string Object)
            {
                this.Object = Object;
            }

        public string Print()
            {
               return "나는"+ Object+"입니다.";
            }
        
        } 
        static void Main(string[] args)
        {
            MyObject[] arrs = new MyObject[3];

            arrs[0] = new MyObject("사람");
            arrs[1] = new MyObject("동물");
            arrs[2] = new MyObject("차");

          
      
            for (int i = 0; i<arrs.Length; ++i)
            {
                Console.WriteLine(arrs[i].Print());
            }

            // ★ if 쓰지 말고 클래스를 사용하기 
            // ★ interface 
            // 출력 : 
            // 나는 사람입니다.
            // 나는 동물입니다.
            // 나는 자동차입니다.
        }
    }
}

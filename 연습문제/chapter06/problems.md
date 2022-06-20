# 연습문제 1

<br/>

- 해답
```
using System;

namespace problems
{
    internal class problem1
    {
        static double Square(double arg)
        {
            return arg * arg;
        }


        static void Main(string[] args)
        {
            Console.Write("수를 입력해주세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0}", Square(arg));
        }
    }
}



```

<br/>


# 연습문제 2
<br/>

- 해답\
메소드의 리턴값이 없어서 메소드 결과 값이 반영되지 않음

1. 메소드 끝에 return mean을 추가한다
2. 참조에 의한 반환 ref를 사용하여 메소드를 구현한다(매개변수와 인자 앞에 ref선언)


<br/>

# 연습문제 3
<br/>

- 해답
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    internal class problem3
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int resulta = 0;

            plus(a, b, out resulta);

            Console.WriteLine("{0} + {1} = {2}",a,b,resulta);

            double x = 2.4;
            double y = 3.1;
            double resultb = 0;

            plus(x, y, out resultb);

            Console.WriteLine("{0} + {1} = {2}", a, b, resultb);
        }

        public static void plus(int a, int b, out int c)
        {
            c = a + b;
        }

        public static void plus(double a, double b, out double c)
        {
            c = a + b;
        }
    }
}


```

<br/>


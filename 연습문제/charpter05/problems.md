# 연습문제 1

<br/>

- 해답
```
using System;

namespace problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num=0; num<5; num++)
            {
                for (int in_num = 0; in_num <= num; in_num++)
                    Console.Write("*");

                Console.WriteLine("");
            }
        }
    }
}

```

<br/>


# 연습문제 2
<br/>

- 해답
```
using System;

namespace problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num=5; num>0; num--)
            {
                for (int in_num = 0; in_num < num; in_num++)
                    Console.Write("*");

                Console.WriteLine("");
            }
        }
    }
}

```

<br/>

# 연습문제 3
<br/>

- 해답

연습문제1 for-> while변환
```
using System;
namespace problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int in_num = 0;
            while (num<5)
            {              
                in_num = 0;
                while (in_num <= num)
                { 
                    Console.Write("*");
                    in_num++;
                }
                Console.WriteLine("");
                num++;
            }
        }
    }
}

```

연습문제2 for-> while변환
```
using System;
namespace problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            int in_num = 0;
            while (num>0)
            {              
                in_num = 0;
                while (in_num < num)
                { 
                    Console.Write("*");
                    in_num++;
                }
                Console.WriteLine("");
                num--;
            }
        }
    }
}

```

<br/>

# 연습문제 4
<br/>

- 해답
```
using System;

namespace problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("반복 횟수를 입력하세요 : ");
            int answer =int.Parse(Console.ReadLine());

            if (answer <= 0)
            {
                Console.Write("0보다 작거나 같은 수는 입력 할 수 없습니다. ");
            }
            else
            {
                for (int num = 0; num < answer; num++)
                {
                    for (int in_num = 0; in_num <= num; in_num++)
                        Console.Write("*");

                    Console.WriteLine("");
                }
            }
        }
    }
}

```

<br/>
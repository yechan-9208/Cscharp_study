# 연습문제 1

<br/>

- 해답
```
클래스는 참조 형식으로 필드와 메소드로 이루어져있다. // 객체를 만들기 위한 청사진이다.
객체는 클래스의 생성자를 통해 생성되어 실제 주소값을 힙으로 가진다. //객체는 속성과 기능을 가지고 있는 실체를 말한다
인스턴스는 객체의 필드를 말한다 //클래스를 통해 만들어진 객체를 인스턴스라고 부름
```
<br/>


# 연습문제 2
<br/>

- 해답
```
A c = new B(); 에서 오류가난다
class B는 class A를 상속받고있기에 
claas A의 기능과 속성은 class B도 사용가능 하지만
claas B의 기능과 속성은 class A에서 사용하지 못한다.
```

<br/>

# 연습문제 3
<br/>

- 해답
```
this는 자기 자신을 가르키는 키워드이고
base는 상속받는 클래스를 가르킨다
```

<br/>

# 연습문제 4
<br/>

- 해답
```
2,3
2 : 구조체는 깊은 복사(힙 복사)를 사용하고 클래스가 얕은 복사를 한다.
3 : 구조체는 저장소를 스택(값 형식)으로 사용하고 클래스가 힙(참조형식)으로 사용한다
```

<br/>

# 연습문제 5
<br/>

- 해답
```
readonly는 변환 불가이므로 target의 값을 할당하는 코드를 지우고
연산 결과를 return해준다

public readonly double GetFahrenheit()
{
    return currentInCelsius * 1.8 + 32;
}

```

<br/>

# 연습문제 6
<br/>

- 오답
```
다형성은 다양한 형태로 선언자를 구하는 것을 의미하고 오버라이딩은 상속 받은 메소드에 기능을 추가하는 것을 의미한다.
```

- 해답
```
다형성은 객체가 여러 형태를 가질 수있음을 의미하고 오버라이딩을 통해 상속받은 메소드를 재정의 해준다.
```

<br/>

# 연습문제 7
<br/>

- 해답
```
private static double GetDiscountRate(object client)
{
    double count = 0.0;

    switch client
    {
        case ("학생",int n) when n<18:
            count = 0.2;
            break;
        case ("학생",_):
            count = 0.1;
            break;
        case ("일반",int n) when n<18:
            count = 0.1;
            break;
        case ("일반",_):
            count = 0.05;
            break;
        default:
            count = 0.0;
    }
    return count;
}
```

<br/>
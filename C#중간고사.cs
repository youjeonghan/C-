// 문자 입력받기
string str;
str = Console.ReadLine();
Console.Write(str);

// 문자열 사이에 변수 삽입
String str = "유정한";
Console.Write($"내 이름은 {str}");

// 문자열 길이
String str = "hi";
Console.Write(str.Length);      // 2

// int 나눗셈은 몫만 나옴
int a = 5, b = 2;
Console.Write(a / b);     // 2

// 삼항연산자
int a = 5, b = 10, c = 1;
Console.Write("둘중 큰 수: " + (a > b ? a : b));
Console.Write("셋중 큰 수: " + (a > b && a > c ? a : b > c ? b : c));

// 문자를 숫자로 변환1
int a = 1;
string str = "10";
Console.Write("합1: " + (a + int.Parse(str)));

// 문자를 숫자로 변환2 (정수)
Console.Write("합2: " + (a + Convert.ToInt32(str)));

// 문자를 숫자로 변환3 (실수)
Console.Write("합3: " + (a + Convert.ToDouble(str)));

// Random 랜덤수
Random rnum = new Random();
int num = rnum.Next(1, 7);      // 1~6
Console.Write(num);

// 다른 방법으로함수 만들기
int add(int a, int b = 3) => a + b;
Console.Write(add(1));

// 참조값 함수로 보내기
int a = 0;
Console.WriteLine(a);       // 0
void add(ref int num)
{
    num++;
}
add(ref a);
Console.WriteLine(a);       // 1
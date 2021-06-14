// 문자 입력받기
string str;
str = Console.ReadLine();
Console.Write(str);


// 공백 정해서 출력
Console.Write($"{"hi",6}");      // "____hi"


// 상수 선언
const int num = 1;


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


// 문자를 숫자로 변환1 (정수, 실수)
int a = 1;
string str = "10";
Console.Write("합1: " + (a + int.Parse(str)));
Console.Write("합1: " + (a + double.Parse(str)));


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


// 참조값 함수로 보내기 (ref, out)
int a = 0;
Console.WriteLine(a);       // 0
void add(ref int num)
{
    num++;
}
add(ref a);
Console.WriteLine(a);       // 1

// 배열 선언 방법 3가지
int[] arr = new int[] { 10, 12, 14 };
int[] arr = { 10, 12, 14 };
int[] arr = new int[3];                 // 초기화 X

// 배열 길이 (만큼 입력 받기)
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}


// 배열 크기 조정 리사이징
int[] arr = new int[3];         // 원래 크기 3
Array.Resize(ref arr, 5);       // 크기 5로 변경


// 2차원 배열 선언 3가지 방법
int[,] arr1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

// 2차원 배열의 길이
int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
Console.WriteLine("행: " + arr.GetLength(0));       // 2
Console.WriteLine("열: " + arr.GetLength(1));       // 3
Console.WriteLine("전체: " + arr.Length);           // 2 x 3 = 6


// 가변 배열 선언 (jagged array)
int[][] jagged = { new int[] { 1, 2 }, new int[] { 3 }, new int[] { 4, 5, 6 } };
int[][] c = new int[4][];
c[0] = new int[3];
c[1] = new int[4];
c[2] = new int[1];
c[3] = new int[2];


// 반복문 사용법 2가지 (for, foreach)
int[] arr = { 1, 2, 3, 4, 5 };
for (var i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
foreach (var item in arr)
{
    Console.Write(item + " ");
}


// Linq 사용법
using System.Linq;
var filtered = from value in values
               where value > 4 && value < 10
               orderby value
               //orderby value    // by default will ascending
               //orderby value descending
               //orderby value ascending
               select value;

// 제네릭 클래스 List<T>
using System.Collections.Generic;
var items = new List<string>();
items.Add("red");               // red
items.Insert(0, "yellow");      // yellow, red
items.Add("green");             // yellow, red, green
items.Remove("yellow");         // red, green       (여러개면 첫번째로나오는거 지움)
tems.RemoveAt(1);               // red          (인덱스 1 인거 지움)


// Linq 사용법
using System.Linq;
var filtered = from value in values
               let upper = value.ToUpper()  // let: 임시변수 / ToUpper: 문자열 대문자로 치환
               where (value == "black" && upper == "BLACK") || upper == "RED"    // 조건절
               where upper.StartsWith("R")  // "R" 로 시작하면 True
               orderby value        //  default ascending
                                    //orderby value descending
                                    //orderby value ascending
               select upper;

// 제네릭 클래스 List<T>
using System.Collections.Generic;
// var items = new List<string>() {"red","black"};      // 초기화 방법
var items = new List<string>();
items.Add("red");               // red      (추가)
items.Insert(0, "yellow");      // yellow, red      (인덱스에 삽입)
items.Add("green");             // yellow, red, green
items.Remove("yellow");         // red, green       (여러개면 첫번째로나오는거 지움)
items.RemoveAt(1);              // red          (인덱스 1 인거 지움)
Console.WriteLine(items.Contains("red"));       // True     (포함 여부 확인)
Console.WriteLine(items.Contains("black"));     // False

// single 상속
// ----------------------------------------------------------------
class A
{
    public void display1() { Console.WriteLine("parent"); }
    public A() { }    // 생성자
}
class B : A
{
    public void display2() { Console.WriteLine("child"); }

    // B(int a):base(a) // 상속 클래스 생성자에 인수 넘겨주기 / base 키워드 사용
    static void Main(string[] args)
    {
        B obj = new B();
        obj.display1();
        obj.display2();
    }
}
// ----------------------------------------------------------------

// 상속, 오버라이드 방지 (클래스, 메서드에 사용)
sealed class A { }

// 메소드 오버라이드 방법 / virtual, override 사용
// ----------------------------------------------------------------
class A
{
    public virtual void display1() { Console.WriteLine("parent"); }
}
class B : A
{
    public override void display1() { Console.WriteLine("child"); }
}
// ----------------------------------------------------------------

// 메소드 오버라이드 방법 / abstract, override 사용
// ----------------------------------------------------------------
abstract class A
{
    public abstract void display1();
}
class B : A
{
    public override void display1() { Console.WriteLine("child"); }
}
// ----------------------------------------------------------------


// 사진 타이머로 변환 (GUI)
// ----------------------------------------------------------------
pictureBox1.Image = imageList1.Images[imageNum % imageList1.Images.Count];
imageNum++;
// ----------------------------------------------------------------


// 사진 업로드 (GUI)
// ----------------------------------------------------------------
OpenFileDialog TestDialog = new OpenFileDialog();
if (TestDialog.ShowDialog() == DialogResult.OK)
{
    pictureBox1.ImageLocation = TestDialog.FileName;
}
// ----------------------------------------------------------------

// dateTimePicker 에서 값 가져오기
// ----------------------------------------------------------------
label1.Text = dateTimePicker1.Value.ToString();
// label1.Text = dateTimePicker1.Value.ToString("MM-dd-yyyy");
// ----------------------------------------------------------------


// MDI 화면 구현
// ----------------------------------------------------------------
child1 child = new child1();
child.MdiParent = this;
child.Show();

this.LayoutMdi(MdiLayout.Cascade)
this.LayoutMdi(MdiLayout.TileVertical);
this.LayoutMdi(MdiLayout.TileHorizontal);
this.LayoutMdi(MdiLayout.ArrangeIcons);
// ----------------------------------------------------------------

// 예외처리
// ----------------------------------------------------------------
try { 예외처리할 부분 }
catch (에러명 e) { }
finally { 무조건 실행되는 부분 }

< 에러 종류 >
Exception
DivideByZeroException
FormatException
IndexOutOfRangeException
// ----------------------------------------------------------------

// 예외처리 만들기 (throw)
try
{
a = int.Parse(Console.ReadLine());
if (a == 0) throw new Exception("씨팔");
}
catch (Exception e) { Console.WriteLine(e); }

// 파일 읽기
using System.IO;
StreamReader file = new StreamReader("C:\\Dev\\Github\\C_sharp_progaming\\test.txt");
string content = file.ReadLine();   // 한줄
string content = file.ReadToEnd();  // 다읽기
Console.WriteLine(content);
file.Close();

// 파일 생성1
StreamWriter file = new StreamWriter(@"C:\Dev\Github\C_sharp_progaming\test.txt");
file.WriteLine("This is seoul");
file.Close();

// 파일 생성2
FileStream file = new FileStream(@"C:\Dev\Github\C_sharp_progaming\test.txt", FileMode.OpenOrCreate, FileAccess.Write);
byte[] bdata = Encoding.ASCII.GetBytes("This is little Difficult line");
file.Write(bdata);
file.Close();

// txt 파일 업로드
OpenFileDialog temp = new OpenFileDialog();
temp.Filter = "Text file|*.txt";
if (temp.ShowDialog() == DialogResult.OK)
{
    var fileStream = temp.OpenFile();
    StreamReader reader = new StreamReader(fileStream);
    textBox2.Text = reader.ReadToEnd();
    reader.Close();
}

// string 나누기
char[] ch = { 'h', 'i', ' ', 'A' };

var string1 = new string(ch);
var string2 = new string(ch, 3, 1);     // 인덱스 3부터 1개
var string2 = new string('C', 3);     // 'C' 를 3번

// string 각종 메서드1
String txt = "Hello";
Console.WriteLine(txt.Length);      // 문자열 길이
Console.WriteLine(txt[1]);
Console.WriteLine(txt.IndexOf("l")); // 해당 글자의 인덱스 번호
Console.WriteLine(txt.IndexOf("l"), 1);
Console.WriteLine(txt.IndexOf("l"), 2);

var txt2 = new char[5] { 'x', 'x', 'x', 'x', 'x' };
txt.CopyTo(3, txt2, 3, 2);  // txt 인덱스3부터, txt2에, 인덱스 3부터, 2번 복사
Console.WriteLine(txt2);

// 비교 메서드
var string1 = "aaa";
var string2 = "bbb";
Console.WriteLine(string.Equals(string1, "aaa"));   // True
Console.WriteLine(string1.Equals("aaa"));
Console.WriteLine(string1 == "aaa");

Console.WriteLine(string1.CompareTo(string2));  // -1
Console.WriteLine(string2.CompareTo(string1));  // 1
Console.WriteLine(string1.StartsWith("a")); // True / a 로 시작하는지
Console.WriteLine(string1.EndsWith("a")); // True / a 로 끝나는지

// string 각종 메서드2
String txt = "Helllol";
char[] search = { 'e', 'l' };
Console.WriteLine(txt.Length);      // 문자열 길이
Console.WriteLine(txt[1]);
Console.WriteLine(txt.IndexOf("l")); // 해당 글자의 인덱스 번호
Console.WriteLine(txt.IndexOf("l", 1));
Console.WriteLine(txt.IndexOf("l", 3)); // 인덱스 3부터
Console.WriteLine(txt.IndexOf("l", 4, 1)); // 인덱스 4부터 1번 찾음(자기자리포함)
Console.WriteLine(txt.LastIndexOf("l"));
Console.WriteLine(txt.IndexOfAny(search));  // 여러개중 찾기
Console.WriteLine(txt.LastIndexOfAny(search));

var txt2 = new char[5] { 'x', 'x', 'x', 'x', 'x' };
txt.CopyTo(3, txt2, 3, 2);  // txt 인덱스3부터, txt2에, 인덱스 3부터, 2번 복사
Console.WriteLine(txt2);


String txt3 = "Hello";
String txt4 = "World";
Console.WriteLine(txt3.Substring(1));   // 앞에서 1개 짜르고 출력
Console.WriteLine(txt3.Substring(0, 2)); // 인덱스0~2 출력
Console.WriteLine(string.Concat(txt3, txt4));    // 합치기
Console.WriteLine(txt3.Replace('l', 'L'));       // l을 L 로 치환

String txt5 = "   Asd   ";
Console.WriteLine(txt5.Trim());     // 공백 자르기
Console.WriteLine(txt5.ToLower());
Console.WriteLine(txt5.ToUpper());
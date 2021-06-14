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


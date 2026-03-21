



//using ConsoleApp3.Enums;
//using ConsoleApp3.Users;
//using System.Text;



//using ConsoleApp3.Enums;
//using ConsoleApp3.Users;

//var person1 = new Person()
//{
//    Name = "John",
//    Surname = "Doe",
//    ECinsiyet = EGender.Man,
//    Fax = "123456789" 
//};
//if(person1.ECinsiyet == EGender.Man)
//{


//}
//int a = 34;
//int b = 35;
//a = b;

//Console.WriteLine($"a = {a} ");
//Console.WriteLine($"b = {b} ");

//var person2 = person1;
//person1.Name = "Mehmet";

//Console.WriteLine($"Person2.Name :{person2.Name}");

//using System.Text;

//string ad = "Ahmet";
//ad = "Mehmet";

//{
//decimal sonuc = 0m;
//for (int i = 0; i < 1000; i++)
//sonuc += i;
//Console.WriteLine("Birinci yöntem : " + sonuc);
//}
//{
//    string sonuc = "";
//    for (int i = 0; i < 1000; i++)
//        sonuc += i.ToString();
//    Console.WriteLine("Birinci yöntem : "   + sonuc);
//}
//{
//    var sb = new StringBuilder();

//    for (int i = 0; i < 1000; i++)
//        sb.Append(i);
//    string sonuc = sb.ToString();
//    Console.WriteLine("İkinci yöntem : "  + sonuc);
//}

//byte a1 = 1;
//byte a2 = 2;
//byte a3 = (byte)(a1 + a2);

void SiparisHazirla(List<string> urunler)
{
    urunler.Remove("Kalem"); // listeyi değiştiriyor!
    // ...
}

var sepet = new List<string> { "Defter", "Kalem", "Silgi" };
SiparisHazirla(sepet);

Console.WriteLine(sepet.Count); //kaç gelir

void Topla(int a, int b)
{
    a = 5;
    b = 6;
}
int a = 40;
int b = 50;
Topla(a, b);
Console.WriteLine($"a değeri: {a}/{b}");



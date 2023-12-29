//Degisken verilerimizi tutan container'lardır.
// string:Metinsel ifadeleri tutar
// integer:Nümeril ifadeleri tutar

string characterName = "Elena";
int characterAge = 25;


characterName = "Mike"; //Yukarıdan asagi derlenerek kodlanir ve Mike yeni ismimiz olur.

Console.WriteLine("Your name is:" + characterName);
Console.WriteLine("Your age is:" + characterAge);


// -----DATAYPES-------

string parapraph = "Hello C# World";
char value = 'a';
int age = 30;
double weight = 30.0;
bool isMale = true;

Console.ReadLine();


//--------- Working String----------
string Value = "WELCOME TO CODE WORLD" + "C#"; // + ifadesi ile string ifadeler birlestirilir

Console.WriteLine(Value.Length); //Uzunlugunu verir
Console.WriteLine(Value);
Console.WriteLine(Value.ToLower()); //Tüm harfleri küçük yapar
Console.WriteLine(Value.ToUpper()); // Tüm harfleri büyük yapar
Console.WriteLine(Value.EndsWith("T")); //Sonu T ile mi bitiyor kontrol eder dogruysa True yanlıs ise False verir
Console.WriteLine(Value.StartsWith("W")); // W ile başlıyor mu diye kontrol eder.
Console.WriteLine(Value[0]); // 0.indeksi bize döndürür.




// -----Working Numbers--------

Console.WriteLine(5 + 8); //Toplama islemi yapar
Console.WriteLine(10 / 2); //Bölme islemi yapar
Console.WriteLine(5 * 10); // Çarpma islemi yapar
Console.WriteLine(10 % 2); //Mod alır kalanı cıktı olarak verir
Console.WriteLine(Math.Abs(-50)); //Sayının mutlak degerini alır ve bastırır
Console.WriteLine(Math.Ceiling(14.5)); //En yakın büyük sayıya yuvarlar
Console.WriteLine((Math.Sqrt(25))); //Kökünü alır


// ------ User Input Working ------

Console.Write("Please Enter Your Name:"); //Kullanıcıdan bilgi almak icin
string name = Console.ReadLine(); //Degiskeni atayalim
Console.WriteLine("Hello" + " " + name);

Console.ReadLine();


//----- BASİC CALCULATOR ------

Console.Write("Please Enter Num1:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please Enter Num2:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num1 + num2);


//------- Arrays ---------

int[] numbers = { 5, 10, 15, 20, 25, 30, 35 };
Console.WriteLine(numbers[1]);
Console.ReadLine();


// ------Methots -------



static void greeter(string name)
{
    Console.WriteLine("Hello" + name);
}
greeter("Mike");
Console.ReadLine();



// ----- Return Statement ------



Console.WriteLine(cube(5));
Console.ReadLine();



static int cube(int num)
{
    int result = num * num * num;
    return result;
}


//İf statement

Console.Write("Lütfen yasinizi giriniz:");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("Lütfen egitim durumunuzu giriniz:");
string egitim = Console.ReadLine();

if (egitim == "Lise" & age >= 19)
{
    Console.WriteLine("Sartlariniz ehliyet icin uygundur.");
}
else if (egitim == "Üniversite" & age >= 19)
{
    Console.WriteLine("Sartlariniz ehliyet icin uygundur.");

}
else
{
    Console.WriteLine("Ehliyet icin uygun degilsiniz.");
}


// -----While Loops -------

int index = 1;
while (index <= 10)
{

    Console.WriteLine(index);
    index++;

}


// ------- For Looops -------

for (int i = 0; i < 20; i++)
{
    Console.WriteLine(i);
}
Console.ReadLine();




int[] number = { 10, 20, 30, 40, 50, 60, 70, 80, 77, 88, 99, 66, 14, 73, 16, 13 };
for (int i = 0; i <= number.Length; i++)
{
    if (number[i] % 2 == 0)
    {
        Console.WriteLine(number[i]);
    }

}
Console.ReadLine();




// -----2D Arrays ----------
int[,] numbertwo = {
    {1,2,3 },
    { 4,5,6},
    {7,8,9 },
};

Console.WriteLine(numbertwo[1, 1]); //1.dizinin 1.elemanını çeker
Console.ReadLine();





//   ------ Exception Handling ------


// SUALL1: Maashdan vergi çıxandan sonra qalan pulu hesablayır
Console.WriteLine("Maashi daxil edin: ");
int mas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vergini daxil edin:  ");
int vergi = Convert.ToInt32(Console.ReadLine());
int qiymet = mas * vergi / 100;
int pul = mas - qiymet;
Console.WriteLine("Elde ne qeder pul qalacaq: "+ pul);


// SUALL2: İstifadəçinin ad və soyadını birləşdirib tam adını göstərir
Console.WriteLine("Ad daxil edin: ");
string ad = Convert.ToString(Console.ReadLine());
Console.WriteLine("Soyad daxil edin: ");
string soyad  = Convert.ToString(Console.ReadLine());
Console.WriteLine("Tam ad: "+ad+ " "+soyad); 


// SUALL3: İstifadəçinin yaşını hesablayır
Console.WriteLine("Dogum ili daxil edin : ");
int il = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Cari ili daxil edin : ");
int caril = Convert.ToInt32(Console.ReadLine());
int yas = caril - il;
Console.WriteLine("yas: " + yas);


// SUALL4: Ballara görə qiymətləndirmə edir
Console.Write("Balı daxil et: ");
int bal = Convert.ToInt32(Console.ReadLine());

if (bal < 50)
    Console.WriteLine("Kesildiniz");
else if (bal < 70)
    Console.WriteLine("Qebul");
else if (bal < 90)
    Console.WriteLine("Yaxshı");
else
    Console.WriteLine("Ela");


// SUALL5: İki ədədin böyüyünü tapır
Console.Write("Birinci ededi daxil et: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci ededi daxil et: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.WriteLine("Boyuk eded: " + a);
else if (b > a)
    Console.WriteLine("Boyuk eded: " + b);
else
    Console.WriteLine("Ededler beraberdir.");


// SUALL6: Edədin cüt və ya tək olduğunu tapır
Console.Write("Ededi daxil et: ");
int eded = Convert.ToInt32(Console.ReadLine());

if (eded % 2 == 0)
    Console.WriteLine("Bu eded cütdür.");
else
    Console.WriteLine("Bu eded tekdir.");


// SUALL7: Yetkin olub-olmadığını yoxlayır
Console.Write("Yaşınızı daxil edin: ");
int yas = Convert.ToInt32(Console.ReadLine());

if (yas >= 18)
    Console.WriteLine("Yetkinsiniz.");
else
    Console.WriteLine("Balacasınız.");


// SUALL8: Ay nömrəsinə görə mövsümü göstərir
Console.Write("Ay nomresini daxil et: ");
int ay = Convert.ToInt32(Console.ReadLine());

if (ay == 12 || ay == 1 || ay == 2)
    Console.WriteLine("Movsum: Qıs");
else if (ay == 3 || ay == 4 || ay == 5)
    Console.WriteLine("Movsum: Yaz");
else if (ay == 6 || ay == 7 || ay == 8)
    Console.WriteLine("Movsum: Yay");
else if (ay == 9 || ay == 10 || ay == 11)
    Console.WriteLine("Movsum: Payız");
else
    Console.WriteLine("Bele ay yoxdur");


// SUALL9: Üç ədədin içində ən böyüyünü tapır
Console.WriteLine("1 ededi daxil edin ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2 ededi daxil edin ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3 ededi daxil edin ");
int c = Convert.ToInt32(Console.ReadLine());

if (a>b && a>c)
    Console.WriteLine("A boyuk ededir");
else if (b>a && b>c)
    Console.WriteLine("B boyuk ededir");
else if (c>a && c>b)
    Console.WriteLine("C boyuk ededir");


// SUALL10: İstifadəçi adı və parol yoxlaması (login sistemi)
string dogruIstifadeci = "admin";
string dogruParol = "1234";

Console.Write("İstifadeci adını daxil et: ");
string istifadeci = Console.ReadLine();

Console.Write("Parolu daxil et: ");
string parol = Console.ReadLine();

if (istifadeci == dogruIstifadeci && parol == dogruParol)
{
    Console.WriteLine("Giris ugurludur! Xos geldiniz.");
}
else
{
    Console.WriteLine("İstifadeci adı ve ya parol səhvdir!");
}


// SUALL11: 1-dən 100-ə qədər olan cüt ədədləri çap edir
for (int i = 1; i <= 100; i ++) 
{
    if (i%2==0)
        Console.WriteLine(" "+ i);
}


// SUALL12: 1-dən 100-ə qədər olan tək ədədləri çap edir
for (int i = 0; i <= 100; i ++) 
{
    if (i%2!=0)
        Console.WriteLine(" "+ i);
}


// SUALL13: 5 dəfə "salam" yazdırır
for(int i=0; i<5; i++)
{
    Console.WriteLine("salam");
}


// SUALL14: 1-dən n-ə qədər ədədlərin cəmini hesablayır
Console.Write("n ededini daxil et: ");
int n = Convert.ToInt32(Console.ReadLine());

int cem = 0;
for (int i = 1; i <= n; i++)
{
    cem += i;
}
Console.WriteLine("cemi: " + cem);


// SUALL15: 0-dan 20-yə qədər 3-ə bölünən ədədləri çap edir
for (int i = 0; i <= 20; i++)
{
    if (i % 3== 0)
        Console.WriteLine(" " + i);
}


// SUALL18: Meyvələri massivdə saxlayıb çap edir
string[] meyveler = { "alma", "armud", "heyva" };
foreach(string meyve in meyveler)
{
    Console.WriteLine(meyve);
}


// SUALL19: Edədlərin cəmini hesablayır
int[] ededler = { 10, 20, 15, 5, 30 };
int cem = 0;

for (int i = 0; i < ededler.Length; i++)
{
    cem += ededler[i];
}

Console.WriteLine("Ededlerin cemi: " + cem);


// SUALL20: 2x2-lik ikiölçülü massiv yaratmaq və çap etmək
int[,] edler = new int[2, 2];
edler[0, 0] = 3;
edler[0, 1] = 4;
edler[1, 0] = 5;
edler[1, 1] = 9;

for(int i=0;i<2;i++)
{
    for(int j=0;j <2;j++)
    {
        Console.Write(edler[i, j]+" ");
    }
    Console.WriteLine();
}


// SUALL21: Massivdəki hər bir ədədin cüt və ya tək olduğunu göstərir
int[] edler = { 2, 6, 7, 57, 89, 44 };

for (int i = 0; i < edler.Length; i++)
{
    if (edler[i] % 2 == 0)
        Console.WriteLine("Eded cutdur: " + edler[i]);
    else
        Console.WriteLine("Eded tekdir: " + edler[i]);
}


// SUALL22: Massivi tərsinə çap edir
int[] edler = { 2, 6, 7, 57, 89, 44 };

for(int j = edler.Length-1;j>=0;j--)
{
    Console.WriteLine(edler[j]);
}


// SUALL26: Funksiya vasitəsilə qiymət + vergi hesablayır
static void Main()
{
    Console.WriteLine("Qiymeti daxil edin: ");
    int qiymet = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("vergi daxil edin: ");
    int vergi = Convert.ToInt32(Console.ReadLine());
    int odenis = odenihesabla(vergi,qiymet);
    Console.WriteLine("odenis: " + odenis);
}

static int odenihesabla(int vergi,int qiymet)
{
    return qiymet + (qiymet * vergi / 100); // Qiymət + vergini hesablayır
}


// SUALL27: Massivin cəmini funksiyada hesablayır
static void Main()
{
    int[] massiv = { 2, 4, 7, 9 };
    int cem = masivincemi(massiv);
    Console.WriteLine("msivin cemi: "+cem);
}

static int masivincemi(int[] arr)
{
    int cem = 0;
    foreach(int eded in arr)
    {
        cem += eded; // Massivin bütün elementlərini cəmləyir
    }
    return cem;
}

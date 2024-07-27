

// Soru 1
// Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız. 

int min = 0;
int max = 10;
    while (min < max)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    min++;
}


// Soru 2
//1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

int sayı = 2;                   // 1 ile 20 arasında dediği için 1 ve 20'yi dahil etmedim.
while (sayı < 20)
{
    Console.WriteLine(sayı);
    sayı++;
}


//Soru 3
//1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

int a = 2;
while (a < 20)
{
    Console.WriteLine(a);
    a += 2;
}


//Soru 4
// 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

int başlangıç = 50;
int bitiş = 150;
int toplam = 0;

while(başlangıç <= bitiş)                   // 50 sayısını birer birer arttıracak toplamla toplayacak. Ancak 150'ye kadar bunu yapacak.
{
    toplam += başlangıç;
    başlangıç++;
}

Console.WriteLine("toplamı" + toplam);

//Soru 5
// 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int ilk = 1;
int cift = 0;
int tek = 0;        // Bu aşamada ileride kullanacağım her değişkene bir sayı atıyorum

while (ilk <= 120)       //Döngüde il sayımın 120'den küçük olması şartını arıyorum çünkü 120'ye kadarki tüm sayılarla ileride işlem yapacağım.
{
    if (ilk % 2 == 0)     // Döngünün içine if değişkenini giriyorum çünkü tek ve çift olma durumunu ayrı ayrı değerlendireceğim.
                           // eğer gelen sayı 2 ye tam bölünüyorsa başta 0 olarak atadığım çift değişkenine bu sayıyı ekle komutu verdim.
    {
        cift += ilk;
    }

    else                  //Ama ikiye tam bölünmüyorsa başta 0 olarak atadığım tek değere bu sayıyı ekle dedim.
    {
        tek += ilk; 
    }

    ilk++;                  // bu aşamada ilk sayımın birer birer artmasını sağlıyorum aksi halde sonsuz döngü olur.
}

Console.WriteLine("Çift sayıların toplamı" + cift); 
Console.WriteLine("Tek sayıların toplamı" + tek);


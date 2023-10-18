// 1. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

Console.Write("Girmek istediğiniz Sayı Adetini Giriniz: ");

int sayiAdeti = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[sayiAdeti];
for (int i=0; i<sayiAdeti; i++)
{
    Console.Write("Lütfen {0}. Sayısı Giriniz: ", i + 1);
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}

Console.Write("Girmiş Olduğunuz Çift Sayılar: ");
int bolonebilenSayi = 0;
for (int i=0; i<sayiAdeti; i++)
{
    if (sayiDizisi[i]%2==0)
    {
        bolonebilenSayi++;
        Console.Write(sayiDizisi[i] + " ");
    }
}



// 2. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

Console.Write("Hangi Sayının Bölünmesini İstersiniz: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Kaç Adet Sayı Girmek İstersiniz: ");
int sayiAdeti1 = int.Parse(Console.ReadLine());
int[] sayiDizisi1 = new int[sayiAdeti1];
for (int i=0; i<sayiAdeti; i++)
{
    Console.Write("Lütfen {0}. Sayısı Giriniz: ", i + 1);
    sayiDizisi1[i] = int.Parse(Console.ReadLine());
}

Console.Write("Girmiş Olduğunuz Çift Sayılar: ");
int bolonebilenSayi1 = 0;
for (int i=0; i<sayiAdeti1; i++)
{
    if (sayiDizisi1[i] % m == 0 || sayiDizisi[i] == m)
    {
        bolonebilenSayi1++;
        Console.Write(sayiDizisi1[i] + " ");
    }
}



// 3. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

Console.Write("Kaç Adet Kelime Girmek İstersiniz: ");
int sayiAdeti2 = int.Parse(Console.ReadLine());
String[] sayiDizisi2 = new String[sayiAdeti2];
for (int i=0; i<sayiAdeti2; i++)
{
    Console.Write("Lütfen {0}. Kelimeyi Giriniz: ", i + 1);
    sayiDizisi2[i] = (Console.ReadLine());
}


Array.Reverse(sayiDizisi2);
Console.Write("Girmiş Olduğunuz Kelimeler: ");
for (int i=0; i<sayiAdeti2; i++)
{
        Console.Write(sayiDizisi2[i] + " ");
    
}




// 4. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

Console.Write("Bir Cümle Yazınız: ");
String sayiDizisi3 = Console.ReadLine();

int harf = sayiDizisi3.Length;
string[] bos = sayiDizisi3.Split(' ');
int bosluksuzharf = harf - (bos.Length - 1);
Console.WriteLine("Toplam Kelime: " + bos.Length + " Toplam Harf: " + bosluksuzharf);
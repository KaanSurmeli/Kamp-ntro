using System.Runtime.CompilerServices;

string kurs1 = "Yazılım Geliştiricisi Yetiştirme Kampı";
string kurs2 = "Programlamaya başlangıç için temel kurs";
string kurs3 = "Java";
//array dizi
string[] kurslar = new string[] {"Yazılım Geliştiricisi yetiştirme kampı",
"Programlamaya başlangıç için temel kurs","Java","Python"};

for (int i = 0; i <kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("Ara");
foreach  (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

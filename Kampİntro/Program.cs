﻿string kategoriEtiketi = "kategoriler";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = true;
double dolarDun = 7.55;
double dolarBugun = 7.45;


if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış Butonu");
}
else if (dolarDun < dolarBugun)
{
    Console.WriteLine("Artış Butonu");
}
else
{
    Console.WriteLine("Değişmedi Butonu");
}
if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı ayarları Butonu");
}
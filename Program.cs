﻿// See https://aka.ms/new-console-template for more information

int a=0;

//Call By Value

static int Topla(int a){
a+=3;
return a;

}


//Call By Referance

static int ToplaReferance(ref int a){

a+=3;
return a;
}
Console.WriteLine(Topla(a));
Console.WriteLine("Referans ile alınmadan önce a: {0}",a);
Console.WriteLine(ToplaReferance(ref a));
Console.WriteLine("Referans ile alındıktan sonra a: {0}",a);

// tryParse
// Parse işlemini yapıp yapamadığını gösteren Boolean değer döndüren bir işlemdir.

string sayı="44ü";
bool sonuc= int.TryParse(sayı, out int TryParsedSayı);
if(sonuc){
    Console.WriteLine("Parse başarılı.");
}
else
{
    Console.WriteLine("Parse Başarısız.");
}


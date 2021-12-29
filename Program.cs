// See https://aka.ms/new-console-template for more information
/* try // hata potansiyeli olan kodumuzu yazarız.
{
     Console.WriteLine("Lütfen bir sayı giriniz:");
     int input= Int32.Parse(Console.ReadLine());
     Console.WriteLine($"Girmiş olduğunuz sayı : {0}",input);
}catch(Exception ex) //Exeption sınıfından bir obje yarattık ve hatamız varsa buradan ne olduğunu öğreneceğiz.
{
    Console.WriteLine(ex.Message); //Mesaj metodunu kullanarak exeption'un mesajını yazdırdık.
}
finally //burada hata alsın almasın son olarak çalıştıracağımız kodu yazarız, zorunlu bir satır değildir.
{
    Console.WriteLine("İşlem tamamlandı.");
}
*/
try
{
     int a = int.Parse(null);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("boş değer girdiniz.");
    Console.WriteLine(ex);
}




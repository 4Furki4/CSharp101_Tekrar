// See https://aka.ms/new-console-template for more information
// Sort,
int[] Dizi={8,3,1,0,9,7,5,4,2,6};
foreach (var item in Dizi)
{
    Console.Write(item);
}

Console.WriteLine("\n----------------------");
Array.Sort(Dizi);
foreach (var item in Dizi)
{
    Console.Write(item);
}


// Clear
Array.Clear(Dizi,2,3); // 2. İndexten başlar ve 3 tane eleman siler: 2. 3. ve 4. index silinir (yerine sıfır yazılır)
// Reverse
Array.Reverse(Dizi); // Diziyi ters çevirir.

// IndexOf
Array.IndexOf(Dizi,4); // İlk parametre olarak kullanacağımız diziyi, ikinci parametre olarak indexini aradığımız değeri yazarız.

//Resize<T> 
Array.Resize<int>(ref Dizi, 16); // ref anahtar kelimesini kullanarak Dizimizi çağırıyoruz ve yanına yeni değerini yazıyoruz.
Console.WriteLine(Dizi.Length);


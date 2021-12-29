using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
// See https://aka.ms/new-console-template for more information
// if else bildiğim için Ternary yazımına bakacağım.
int time = DateTime.Now.Hour;

string sonuc = time>=18 && time<11 ? "Günaydın" : time<18 ? "İyi günler" : "İyi geceler"; //koşul; sonra soru işareti (?), sonraysa gerçekleşecek ifade. 
// Koşul doğruysa soru işaretinin yanındaki ifadeyi gerçekleştirir, değilse ":" ile else gibi kullanırız. :'dan sonra koşul gelirse else if gibi çalışır.
        
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        string outcome= N%2==1 ? "Weird" : N%2==0 && N>=2 &&N<=5 ? "Not Weird" : N%2==0 && N>=6 &&N<=20 ? "Weird" :  N%2==0 && N>20 ? "Not Weird": null;
        Console.WriteLine(outcome);








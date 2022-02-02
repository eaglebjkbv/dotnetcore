// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string dene="hello world";
int sayi=10;
sayi.EkranaSayiYaz();
dene.EkranaYaz();
System.Console.WriteLine($" Stringin uzunluğu:{dene.Uzunluk().ToString()}");  
"Stringin Uzunluğu".EkranaYaz();
dene.Uzunluk().EkranaSayiYaz();    

public static class Uzatilmis
{
    public static void EkranaYaz(this string mesaj)
    {
        System.Console.WriteLine(mesaj);
    }
    public static void EkranaSayiYaz(this int mesaj)
    {
        System.Console.WriteLine(mesaj);
    }
    public static int Uzunluk(this string mesaj)
    {
        
        return mesaj.Length;;
    }
}
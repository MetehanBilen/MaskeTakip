//Degiskenler();

using Business.Concrete;
using Entities.Concrete;

Vatandas vatandas1 = new Vatandas();


//Console.ReadLine();

SelamVer("Mt");
SelamVer();

//Diziler || Arrays

string ögrenci1 = "Engin";
string ögrenci2 = "Kerem";
string ögrenci3 = "Berkay";

string[] ögrenciler = new string[3];
ögrenciler[0] = ögrenci1;
ögrenciler[1] = ögrenci2;
ögrenciler[2] = ögrenci3;

foreach (string ögrenci in ögrenciler)
{
    SelamVer(ögrenci);
}

//Generic Collection
List<string> yeniSehirler = new List<string> { "Ankara", "İstanbul", "İzmir" };
yeniSehirler.Add("Adana");

Person person = new Person();
person.FirstName = "MT";
person.LastName = "BLN";
person.DateOfBirthYear = 1000;
person.NationalIdentity = 123;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);



static void Degiskenler()
{
    string mesaj = "Selam";
    double tutar = 1000000.5;
    int sayi = 100;
    bool girisYapmisMi = false;
    string ad = "Mt";
    string soyad = "Bln";
    int dogumYili = 1997;
    long tcNo = 12345678910;

    Console.WriteLine(mesaj);

    Console.WriteLine(mesaj);
}

//Default parametreler en sona yazılır.
//resharper
static void SelamVer(String isim= "isimsiz")
{
    Console.WriteLine("Merhaba "+ isim);
}
//pascal casing
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set;}
}
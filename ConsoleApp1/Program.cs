using System.Runtime.CompilerServices;

Console.Write("masukan nama : ");
string nama = Console.ReadLine();
Console.Write("masukan nilai harian : ");
int nilaiharian = Convert.ToInt32(Console.ReadLine());
Console.Write("masukan nilai uts : ");
int nilaiuts = Convert.ToInt32(Console.ReadLine());
Console.Write("masukan nilai uas : ");
int nilaiuas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("___________________________");

Console.WriteLine("nama : " + nama);
Console.WriteLine("nilai harian : " + nilaiharian);
Console.WriteLine("nilai uts : " + nilaiuts);
Console.WriteLine("nilai uas : " + nilaiuas);

int rata = (nilaiharian + nilaiuts + nilaiuas) / 3;

if (rata >= 80)
{
    Console.WriteLine("nilai rata-rata anda : " + rata);
    Console.WriteLine("predikat anda : A");
}
else if (rata >= 70)
{
    Console.WriteLine("nilai rata-rata anda : " + rata);
    Console.WriteLine("predikat anda : B");
}
else if (rata >= 60)
{
    Console.WriteLine("nilai rata-rata anda : " + rata);
    Console.WriteLine("predikat anda : C");
}
else if (rata >= 50)
{
    Console.WriteLine("nilai rata-rata anda : " + rata);
    Console.WriteLine("predikat anda : D");
}
else 
{
    Console.WriteLine("nilai rata-rata anda : " + rata);
    Console.WriteLine("predikat anda : E");
}

Console.ReadKey();


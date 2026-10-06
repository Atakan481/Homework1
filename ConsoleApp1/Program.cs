Console.WriteLine("Hello C#");

Console.WriteLine();



Console.WriteLine("Ad Soyad: Atakan Şahin");
Console.WriteLine("Bölüm: Bilgisayar Mühendisliği");
Console.WriteLine("Yıl: 2.Sınıf");

Console.WriteLine();



Console.WriteLine("Güncel Tarih ve Saat:" + DateTime.Now);

Console.WriteLine();



Console.Write("Celcius değerini girin: ");
string girdi = Console.ReadLine();
double celcius = Convert.ToDouble(girdi);
double fahrenheit = (celcius * 9 / 5) + 32;

Console.WriteLine("Fahrenheit değeri: " + fahrenheit);

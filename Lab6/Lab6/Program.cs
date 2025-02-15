// Przykłady

//string path = "example.txt";

// ex. 1 - Tworzenie pliku i zapis danych


//string content = "Hello, C# File Operations!";
//// Tworzenie pliku i zapisanie danych
//File.WriteAllText(path, content);
//System.Console.WriteLine("Plik został utworzony.");

// ex. 2 - Odczyt danych z pliku

//if (File.Exists(path))
//{
//    string content = File.ReadAllText(path);
//    System.Console.WriteLine("Zawartość pliku: " + content);
//}
//else
//    System.Console.WriteLine("Plik nie istnieje.");

// ex. 3 - Dopisywanie danych do istniejącego pliku

//string newContent = "\nThis is additional content.";
//File.AppendAllText(path, newContent);
//System.Console.WriteLine("Dane zostały dopisane do pliku.");

// ex. 4 - Usuwanie pliku

//if (File.Exists(path))
//{
//    File.Delete(path);
//    System.Console.WriteLine("Plik został usunięty.");
//}
//else
//{
//    System.Console.WriteLine("Plik nie istnieje.");
//}

// ex.5 - Użycie klasy FileStream do zapisu i odczytu

//string path = "example.bin";
//// Zapis do pliku binarnego
//using (FileStream fs = new FileStream(path, FileMode.Create))
//{
//    byte[] data = { 1, 2, 3, 4, 5 };
//    fs.Write(data, 0, data.Length);
//}
//// Odczyt z pliku binarnego
//using (FileStream fs = new FileStream(path, FileMode.Open))
//{
//    byte[] buffer = new byte[fs.Length];
//    fs.Read(buffer, 0, buffer.Length);
//    System.Console.WriteLine("Odczytano dane:");
//    foreach (byte b in buffer)
//    {
//        System.Console.Write(b + " ");
//    }
//}


// z. 3 

//Console.WriteLine("Podaj nazwę pliku do którego chcesz zapisać dane: ");
//string path = Console.ReadLine();

//string nrAlbumu = "w12345";
//try
//{
//    File.WriteAllText(path, nrAlbumu);
//    Console.WriteLine("Dane zapisano do pliku.");
//}
//catch(Exception ex)
//{
//    Console.WriteLine($"Błąd w zapisie do pliku: {ex.Message}");
//}

// z. 4

string path = "pesele.txt";
try
{
    if (!File.Exists(path))
    {
        Console.WriteLine("Plik nie istnieje.");
        return;
    }

    string[] peselelist = File.ReadAllLines(path);

    int FemCount = peselelist.Count(IsFem);

    Console.WriteLine("Ilość Kobiet: " + FemCount);
    int MascCount = peselelist.Length - FemCount;
    Console.WriteLine("Ilość Mężczyzn: " + MascCount);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
static bool IsFem(string pesel)
{
    if (pesel.Length != 11) return false;

    char cyfra = pesel[9];
    return cyfra % 2 == 0;
}
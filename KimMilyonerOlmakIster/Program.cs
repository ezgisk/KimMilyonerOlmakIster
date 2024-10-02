int correctAnswerCount = 0;

//sorulari stringe atama
string[] questions = {
            "Kızınca tüküren hayvan hangisidir? (a) Lama (b) Deve",
            "Dünya'ya en yakın gezegen hangisidir? (a) Venüs (b) Mars",
            "5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır? (a) 7 (b) 12"
        };
string[] correctAnswers = { "a", "a", "b" };

// Soruları sorma
for (int i = 0; i < 2; i++)
{
    Console.WriteLine(questions[i]);
    Console.Write("Cevabınızı girin (A veya B): ");
    string cevap = Console.ReadLine().ToLower(); // Kullanıcının cevabını al

    if (cevap == correctAnswers[i]) // Doğru cevabı kontrol et
    {
        Console.WriteLine("Doğru cevap!");
        correctAnswerCount++; // Doğru cevap sayısını artır
    }
    else
    {
        Console.WriteLine("Yanlış cevap!");
        // Eğer iki yanlış cevap verildiyse, son soruyu sormadan çık
        if (i == 1) // İkinci soruda yanıt yanlışsa
        {
            Console.WriteLine("Maalesef büyük ödülü kazanamadınız.");
            return; // Programdan çık
        }
    }
}

// Üçüncü soruyu sor
Console.WriteLine(questions[2]);
Console.Write("Cevabınızı girin (A veya B): ");
string sonCevap = Console.ReadLine().ToLower(); // Kullanıcının cevabını al

if (sonCevap == correctAnswers[2]) // Doğru cevabı kontrol et
{
    Console.WriteLine("Doğru cevap!");
    correctAnswerCount++; // Doğru cevap sayısını artır
}
else
{
    Console.WriteLine("Yanlış cevap!");
}

// Sonuç kontrolü
if (correctAnswerCount >= 2)
{
    Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
}
else
{
    Console.WriteLine("Maalesef büyük ödülü kazanamadınız.");
}
    

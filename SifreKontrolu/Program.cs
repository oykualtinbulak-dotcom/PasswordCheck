int count =0;
Console.Write("Şifre Giriniz:");
string password1 = Convert.ToString(Console.ReadLine());
string password2 = "Senkimsin1234!";
while (password1 != password2)
{
    count = count + 1;
    if (count == 3)
    {
        Console.Write("hesap kitlendi");
        break;
    }
    
    Console.Write("Şifreyi Tekrar Girin:");
    password1 = Console.ReadLine();

}
Console.Write("hoşgeldiniz");


string words =Console.ReadLine();
string total = "";

foreach (var word in words.Split(' '))
{
    string temp = "";
    foreach (var ch in word.ToCharArray())
    {
        temp = ch + temp;
    }
    total = total + temp + " ";
}
Console.WriteLine(total);


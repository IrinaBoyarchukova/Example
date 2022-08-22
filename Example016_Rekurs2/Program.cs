// // Собрать сторку от а до b, где a<=b

string NumbersRec (int a, int b)
{
    if (a<=b) return $" {a} " + NumbersRec (a+1, b);
    else return String.Empty;
}
//Console.WriteLine (NumbersRec(1, 10));

// Число a в степени n

int PowerRec (int a, int n)
{
    if (n ==0) return 1;
    else return PowerRec (a, n-1) *a;
}

// Все возможные слова из символов
// int n=1;
// void FindWords (string alphabet, char[] word, int length = 0);
// {
//     if (length == word.length)
//     {
//         Console.WriteLine ($" {n++} {new String(word)} "); 
//         return;
//     }

//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }
// }

//FindWords ("аисв", new char[3]);

//Получаем доступ к директории и информацию о ней

string path = "/Users/User/Desktop/Счета контрагентам/Счета Код молодости";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine (di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine (fi[i].Name);
}

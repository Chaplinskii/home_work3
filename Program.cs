// Задача 1:
//  Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 

// string CriatStr(char[,] ch)
// {
//     string result = "";
//     for (int i = 0; i < ch.GetLongLength(0); i++)
//     {
//         for (int j = 0; j < ch.GetLength(1); j++)
//         {
//             result += ch[i, j];
//         }
//     }
//     return result;
// }
// Console.Clear();
// char[,] array = { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };
// Console.WriteLine(CriatStr(array));

// Задача 2: 
// Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 


// int[] convert(string str)
// {
//     int n = str.Length;
//     char chars = ' ';
//     int[] utf8 = new int[n];
//     for (int i = 0; i < str.Length; i++)
//     {
//         chars = Convert.ToChar(str[i]);
//         utf8[i] = Convert.ToInt32(chars);
//     }
//     return utf8;
// }
// string change(int[] array)
// {
//     char chars = ' ';
//     string result = "";
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 65 && array[i] <= 90)
//         {
//             array[i] += 32;
//         }
//         chars = Convert.ToChar(array[i]);
//         result += Convert.ToString(chars);
//     }
//         return result;
// }
// Console.Clear();
// Console.Write("Введите строку: ");
// string str = Console.ReadLine()!;
// int[] utf8=convert(str);
// Console.WriteLine(change(utf8));

// Задача 3: 
// Задайте произвольную строку. Выясните,
// является ли она палиндромом.

bool Answer (string str){
    for (int i=0;i<str.Length/2;i++){
        if (str[i]!=str[str.Length-1-i]){
            return false;
        }
        
    }
    return true;
}
void PrintAnswer(bool answer){
    if (answer==true){
    Console.WriteLine("Yes");
    }
    else {
    Console.WriteLine("No");
    }
}
Console.Clear();
Console.Write("Введите строку: ");
string str = Console.ReadLine()!;
PrintAnswer(Answer(str));
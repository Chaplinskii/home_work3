// Задача 1:
//  Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 

string CriatStr(char[,] ch)
{
    string result = "";
    for (int i = 0; i < ch.GetLongLength(0); i++)
    {
        for (int j = 0; j < ch.GetLength(1); j++)
        {
            result += ch[i, j];
        }
    }
    return result;
}
Console.Clear();
char[,] array = { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };
Console.WriteLine(CriatStr(array));
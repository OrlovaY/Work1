//Написать программу, которая из имеющегося массива строк формирует новый массив 
//из строк, длина которых меньше, либо равна 3 символам.

string[] A;
/*
System.Console.WriteLine("Введите массив строк через пробел");
string? s=Console.ReadLine();
A=s.Split(' ');
var A1=new string[A.Length];
var index=0;
    foreach (var value in A)
        {
            if (value.Length<4)
                {
                  A1[index]=value;
                  index++;
                  System.Console.Write($"\"{value}\" ");
                }
        }
System.Console.WriteLine();
*/

//string[] array1 = new string[4] {"Hello", "2", "world", ":-)"}; 
string[] Mass1 = new string[3] { "Russia", "Denmark", "Kazan" };
//string[] array1 = new string[4] { "1234", "1567", "-2", "computer science" };
string[] Mass2 = new string[Mass1.Length];
void NewMass(string[] Mass1, string[] Mass2)
{
    int count = 0;
    for (int i = 0; i < Mass1.Length; i++)
    {
        if (Mass1[i].Length <= 3)
        {
            Mass2[count] = Mass1[i];
            count++;
        }
    }
}
void PrintArray(string[] Mass)
{
    for (int i = 0; i < Mass.Length; i++)
    {
        Console.Write($"{Mass[i]}");
    }
    Console.WriteLine();
}
NewMass(Mass1, Mass2);
PrintArray(Mass2);
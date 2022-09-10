//Написать программу, которая из имеющегося массива строк формирует новый массив 
//из строк, длина которых меньше, либо равна 3 символам.
/*
string[] A;

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


string[] A;
System.Console.WriteLine("Введите массив строк через пробел");
string? s=Console.ReadLine();
A=s.Split(' ');
string[] A1 = new string[A.Length];
void NewMass(string[] A, string[] A1)
{
    int count=0;
    for (int i=0; i < A.Length; i++)
    {
        if (A[i].Length<4)
        {
            A1[count]=A[i];
            count++;
        }
    }
}
void PrintArray(string[] Mass)
{
    for (int i = 0; i < Mass.Length; i++)
    {
        Console.Write($"{Mass[i],3}");
    }
    Console.WriteLine();
}
NewMass(A, A1);
PrintArray(A1);
//Написать программу, которая из имеющегося массива строк формирует новый массив 
//из строк, длина которых меньше, либо равна 3 символам.

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
          



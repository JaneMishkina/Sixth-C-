/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10


int x = Convert.ToInt32(Console.ReadLine());
string bin = Convert.ToString(x,2);
 
Console.WriteLine(bin);  */   

Console.WriteLine("Введите число для перевода в двоичную систему: ");
int number = Convert.ToInt32(Console.ReadLine());
string number_str = "";
while (number > 0)
{
    number_str = number_str + number % 2;
    number = number / 2;

}

Console.WriteLine(new string(number_str.Reverse().ToArray()));
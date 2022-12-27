/*Задача 1
Случайное трехзначное число и
удалить вторую цифру этого числа
456 -> 46*/
// int num = new Random().Next(100, 1000);
// int res = (num/100)*10 +num%10;
// Console.WriteLine($"{num} -> {res}");           //вариант 1
// Console.WriteLine($"{num} -> {num/100}{num%10}");//вариант 2

/*Задача 2
Найти большее число из случайных чисел */

// int num = new Random().Next(10,100);
// Console.WriteLine($"{num} ");
// int num1 = num/10;
// int num2 = num%10;
// if(num1 > num2)
// Console.WriteLine($"Больше {num1} ");
// else
// Console.WriteLine($"Больше {num2} ");

/*Задача з
Два заданных числа,
деляться ли они между собой без остатка */

// Console.WriteLine("Введите число 1, ");
// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число 2, ");
// int num1 = int.Parse(Console.ReadLine()!);

// if(num % num1 == 0)
// {
//     Console.WriteLine($"Число {num} кратно числу {num1}");
// }
// else
// {
//     Console.WriteLine($"Число {num} и число {num1} не кратное, с остатком ");
// }
/*Задача 4
Оператор И &&
Оператор ИЛИ ||
принимаем одно число и проверяем кратно ли оно*/

// Console.WriteLine("Введите число, ");
// int num = int.Parse(Console.ReadLine()!);
// if((num % 7 == 0) && (num % 23 == 0))
// {
//     Console.WriteLine($"{num} кратно 7 и 23 одновременно. ");
// }
// else
// {
//     Console.WriteLine($"{num} не кратно 7 и 23 одновременно. ");

// }
/*Задача 5
Принимаем два числа, являеться квадратом
одно другому */
// Console.WriteLine("Введите число 1, ");
// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число 2, ");
// int num1 = int.Parse(Console.ReadLine()!);
// if((num == Math.Pow(num1, 2))|| (num == Math.Pow(num1, 2))){
//     if(num == Math.Pow(num1, 2)){
//     Console.WriteLine($"Число{num} являеться квадратом {num1}, ");
//     }
//     if(num1 == Math.Pow(num, 2)){
//     Console.WriteLine($"Число{num1} являеться квадратом {num} ");
//     }
// }    
// else{
//     Console.WriteLine("Число не являеться квадратом второго ");
// }
//ДЗ
/*Задача 1: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе 
показывает вторую цифру этого числа. 
Обязательна проверка на ввод чисел
 больше/меньше 3-х знаков
456 -> 5
782 -> 8
918 -> 1*/
// Console.WriteLine("Домашнее задание, ");
// Console.Write("Введи трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string num1 = Convert.ToString(num);
// Console.WriteLine("вторая цифра этого числа -> "+num1[1]);
//ДЗ
/*Задача 2: 
Напишите программу, 
которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет. 
Берем числа до 100000
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
// Console.WriteLine("Домашнее задание, ");
// Console.Write("Введи число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string num1 = Convert.ToString(num);
// if (num1.Length > 2){
//   Console.WriteLine("третья цифра -> " + num1[2]);
// }
// else {
//   Console.WriteLine("-> третьей цифры нет");
// }
//ДЗ
/*Задача 3: Напишите программу, 
которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным. 
Обязательна проверка на ввод числа <1 и >7
6 -> да
7 -> да
1 -> нет*/
Console.WriteLine("Домашнее задание, ");
Console.Write("Введите день недели от 1, до 7, ");
int dNum = Convert.ToInt32(Console.ReadLine());

  if (dNum == 6 || dNum == 7) {
  Console.WriteLine("Этот день выходной Ура -> Да");
  }
  else if (dNum < 1 || dNum > 7) {
    Console.WriteLine("Введите число от 1 до 7, ");
  }
  else Console.WriteLine("Этот день не выходной -> Нет");


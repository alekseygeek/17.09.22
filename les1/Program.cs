//Console.Clear();
//Console.WriteLine("введите число");
//int q = Convert.ToInt32(Console.ReadLine());
//int r;
//r = q * q;
//Console.WriteLine($"результат{r}");

// ветвление
// если (на улице дождь ) // условие
//       (то возьми зонт) / действие
//иначе 
//         (иди в сандвлях) действие 2

//int rain = 1;
//if (rain == 1)
//{
//    Console.WriteLine("возьми зонт");
//}
//else
//{
//   Console.WriteLine("иди в сандалях");
//}
// Цикл один выход
//  int time = 11;
//  while(time < 22)
//  {
//     time++;
//     Console.WriteLine("ещё можно" + time);
//  }
// Console.WriteLine("пора спать");
// Console.WriteLine(time);
 // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

  // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

if ( a % 2 == 1)
{
    Console.WriteLine("Число : " + a + " не чётное");
}
else
{
     Console.WriteLine("Число : " + a + "чётное");
}
            


/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Input number => ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Nuber {number} - yes.");
  }
  else Console.WriteLine($"Number: {number} - no .");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Input correct number");
//Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

int Promt(string message){
System.Console.Write(message); //Вывести сообщение
string readValue = Console.ReadLine(); //Считывает с консоли строку
int result = int.Parse(readValue); //Преобразует строку в целое число
return result; }// Возвращает результат функции

int number1 = Promt("Введите первое число ");
int number2 = Promt("Введите второе число ");
int number3 = Promt("Введите третье число ");


int max = number1;
if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

System.Console.WriteLine($"Наибольшее число {max}");

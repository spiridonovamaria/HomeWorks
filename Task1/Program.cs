//Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.

int Promt(string message){
System.Console.Write(message); //Вывести сообщение
string readValue = Console.ReadLine(); //Считывает с консоли строку
int result = int.Parse(readValue); //Преобразует строку в целое число
return result; }// Возвращает результат функции

int value1 = Promt("Введите первое число ");
int value2 = Promt("Введите второе число ");

if (value1 > value2) {
System.Console.WriteLine($"Наибольшее число {value1} ");
System.Console.WriteLine($"Наименьшее число {value2}");
}

else {
System.Console.WriteLine($"Наибольшее число {value2} ");
System.Console.WriteLine($"Наименьшее число {value1}");

}
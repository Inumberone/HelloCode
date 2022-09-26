//Программа которая выдают сумму чисел от 1 до А

Console.WriteLine("Введи число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {A} равна {GetSum(A)}");
int GetSum(int limit){
    int sum = 0;
    for(int i = 1; i<= limit; i++){
        sum=sum+i;
    }
    return sum;
}

//Напишите программу, которая принимает на вход число и выдает количество цифр в числе 456>3

Console.WriteLine("Введи число А: ");
string A = Console.ReadLine()!;
Console.WriteLine($"Количество цифр в числе {GetLength(A)}");
Console.WriteLine($"Количество цифр в числе вторым методом {GetLength2(int.Parse(A))}");

int GetLength(string number)
{
    return number.Length;
}

//var 2

int GetLength2(int number)
{
    return (int)Math.Log10(number)+1;
}


//Напишите прогу, которая принимает на вход число N и выдает произведение чисел от 1 до N

Console.WriteLine("Введи число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"произведение чисел от 1 до {A} равна {GetMult(A)}");
int GetMult(int limit){
    int mult = 1;
    for(int i = 1; i<= limit; i++){
        mult*=i;
    }
    
    return mult;

}

// Написать прогу, которая выводит маасив из 8 элементов, заполненный нулями и единицами в случайном порядке

int[] array = FillArray(8);
Console.WriteLine($"[{String.Join(',', array)}]");

int[] FillArray(int size)
{
    int[] result= new int[size];
    for (int i=0; i< size; i++)
    {
    result[i] = new Random().Next(2);
    }

    return result;

}
--------------------------------------------------------------------------------------------------------------------------------------------
//Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
int num = new Random().Next(100, 1000);
int secondNumber = num / 10 % 10;
Console.WriteLine($"Вторая цифра в числе {num} -> {secondNumber}");

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
Console.WriteLine("Выберите вариант решения: ");
int chosenNumber = int.Parse(Console.ReadLine());

if (chosenNumber == 1){
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    if (num < 100)
    {
        Console.WriteLine($"Третьей цифры нет");
        return;
    }
    int thirdNumber = 0;
    if( num > 99 && num < 1000){
        thirdNumber = (num % 100) % 10;
    }
    if(num > 999 && num < 10000){
        thirdNumber = (num % 100) / 10;
    }
    if(num > 9999 && num < 100000){
        thirdNumber = (num % 1000) / 100;
    }
    if(num > 99999 && num < 1000000){
        thirdNumber = (num % 10000) / 1000;
    }
    Console.WriteLine($"Третья цифра числа {num} -> {thirdNumber}");
}

if (chosenNumber == 2){
    Console.Write("Введите число: ");
    string number = Console.ReadLine()!;
    if (number.Length < 3){
        Console.WriteLine($"Третьей цифры нет!");
    }
    else{
        Console.WriteLine($"Третья цифра числа {number} == {number[2]}");
    }
}

else if (chosenNumber < 1 || chosenNumber > 2) {
    Console.Write("Такого варианта нет!");
}















//-----------------------------------------------------------------ДЗ Семинар 3-----------------------------------------------------------------------------------------
//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Выберите вариант решения: ");
int chosenNumber = int.Parse(Console.ReadLine()!);


if (chosenNumber == 1){
    Console.WriteLine("input 5num number");

    int a = int.Parse(Console.ReadLine());

    if (a >= 10000 && a < 100000)
    {
        int xx = a / 1000;  
        int num1 = xx / 10;
        int num2 = xx % 10;
        int yy = a % 100;
        int num4 = yy / 10;
        int num5 = yy % 10;
        
        if ((num1 == num5) & (num2 == num4))
        {
            Console.WriteLine("this num is palindrom");
        }

        else 
        {
        Console.WriteLine(" num is NOT palindrom");
        }
    }
    else
    {
    Console.WriteLine("wrong num"); 
    }
}

if (chosenNumber == 2){
    Console.Write("Введите число : ");
    string number = Console.ReadLine()!;

    if (number.Length == 5){
        if(number[0] == number[4] && number[1] == number[3]){
            Console.Write("Число является палиндромом");
        }
        else{
            Console.Write("Число не является палиндромом");
        }
    }
    else{
        Console.Write("Введено неверное число!");
    }
}

else if (chosenNumber < 1 || chosenNumber > 2) {
    Console.Write("Такого варианта нет!");
}
// Task1
// напишите программу, которая принимает на вход трехзначное число и на выходе показывает 
//вторую цифру этого числа

// int num = new Random().Next(100,1000);

// Console.WriteLine(num);

// int num1= (num/10)%10;

// Console.WriteLine(num1);

// Task2

// напишите программу, которая выводит третье число или говорит что его нет

// int num = new Random().Next(10,1000);

// Console.WriteLine(num);

// if(num/100 > 1)
// {
//     Console.WriteLine((num%10)%10);
// }
// else
// {
//     Console.WriteLine("третьей цифры нет");
// }

// Task 3
// написать программу, которая принимает на вход цифру день недели а на выходе пишет выходной ли он

int num = new Random().Next(1,8);
Console.WriteLine(num);

if(num<6)
{
    Console.WriteLine("нет");
}
else{
    Console.WriteLine("да");   
}

int Input(string text){
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

(int, int, int) GetDot(){
    return (Input("Введите Х: "),Input("Введите Y: "),Input("Введите Z: "));
}

void Task19(){
    // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    int num;
    while(true){
        num = Input("Введите пятизначное число - ");
        if ((num >= 10000)&&(num < 100000)) break;
        else Console.WriteLine("Введенное число не пятизначное");
    }

    int num1 = num / 1000;
    int num2 = num % 100;
    
    num2 = (num2%10 * 10) + (num2/10);

    if(num1==num2)
        Console.WriteLine("Полиндром!");
    else
        Console.WriteLine("Не полиндром!");
}

void Task21(){
    // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    int x1, y1, z1, x2, y2, z2;

    Console.WriteLine("Введите координаты первой точки");
    (x1,y1,z1) = GetDot();
    Console.WriteLine("Введите координаты второй точки");
    (x2,y2,z2) = GetDot();

    double result = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));

    Console.WriteLine($"Растояние между точками - {Math.Round(result,2)}");
}

void Task23(){
    // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    int num = Input("Введите число - ");

    for(int i = 1; i <= num; i++){
        Console.WriteLine($"{i}^3 = {Math.Pow(i,3)}");
    }
}

Console.WriteLine("1 - Задача 19");
Console.WriteLine("2 - Задача 21");
Console.WriteLine("3 - Задача 23");
switch (Input("Введите номер задачи - ")){
    case 1:
        Task19();
        break;
    case 2:
        Task21();
        break;
    case 3:
        Task23();
        break;
    default:
        Console.WriteLine("Задачи с таким номером не существует");
        break;
}


//  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    // Ввод данных

Console.Write("Введите число: ");
string? num = Console.ReadLine();

    // Функция определения палиндрома

void checknum(string num){
  if (num[0]==num[4] && num[1]==num[3]){
    Console.WriteLine("Ваше число - палиндром.");
  }
  else Console.WriteLine("Ваше число - не палиндром.");
}
    // Проверка числа и вывод ответа

if (num!.Length == 5){ 
  checknum(num);
}
else Console.WriteLine("Введите пятизначное число");

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

   // Ввод даннах 

int x1 = Coordinate("x", "1");
int y1 = Coordinate("y", "1");
int z1 = Coordinate("z", "1");
int x2 = Coordinate("x", "2");
int y2 = Coordinate("y", "2");
int z2 = Coordinate("z", "2");

int Coordinate(string Axis, string point)
{
    Console.Write($"Введите координату {Axis} точки {point}: ");
    return Convert.ToInt32(Console.ReadLine());
}
   // Вычисление длины отрезка соединяющего 2 точки 

double calculation(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double length =  Math.Round (calculation(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {length}");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

    // Функция возведения в куб чисел до N

void Cube (int n){
    int i = 1;
    while(i <= n){
        int result=i*i*i;
        i++;
        Console.WriteLine(result);
       }}

   // Ввод числа , проверка на условие и вывод результата

Console.Write("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine());
if (n <= 0) Console.Write("Некорректный ввод");
else Cube(n); 
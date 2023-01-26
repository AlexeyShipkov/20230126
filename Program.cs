/*Console.WriteLine("input number");
int my_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"your number {my_number*my_number}");
*/
/*
Console.Write("Input your first number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your second numder: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if(number_1 == number_2 * number_2) // проверка на равенство
    Console.WriteLine($"Число {number_1} является квадратом числа {number_2}");
else

    Console.WriteLine($"Число {number_1} не является квадратом числа {number_2}");
*/
Console.Write("input your number N:  ");
int num = Convert.ToInt32(Console.ReadLine());
int current_num = (-1)*num;
while (current_num <= num)
{
Console.WriteLine(current_num);
current_num = current_num+1;
}

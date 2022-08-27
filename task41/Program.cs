//Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] MakeArray(int len) {
    int[] array =  new int[len];
    for (int i = 0; i < len; i++) {
        Console.Write($"Введите {i+1}-й элемент: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void Count (int[] array, int len) {
    int count = 0;
    for (int i = 0; i < len; i++) {
        if (array[i] > 0) {
            count++;
        }
    }
    Console.WriteLine($"Количество чисел больше нуля = {count}");
}

Console.Write("Введите М (кол-во чисел): ");
int M = int.Parse(Console.ReadLine());
int[] array = MakeArray(M);
Count(array, M);
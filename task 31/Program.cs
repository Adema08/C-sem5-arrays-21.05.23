// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] Fill(int size) {
    int[] array = new int[size];
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++) {
        array[i] = rand.Next(-9, 10);
    }
    return array;
}

Console.Write("Размер массива: ");
int s = Convert.ToInt32(Console.ReadLine());
int[] array = Fill(s);
Console.WriteLine(string.Join(", ", array));
int sum1 = 0;
int sum2 = 0;
for(int i = 0; i < array.Length; i++) {
    if(array[i] > 0) {
        sum1 += array[i];
    }
    else {
        sum2 += array[i];
    }
}
Console.WriteLine($"Сумма положительных чисел массива: {sum1}");
Console.WriteLine($"Сумма отрицательных чисел массива: {sum2}");


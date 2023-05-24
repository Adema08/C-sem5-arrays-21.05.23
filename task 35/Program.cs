// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] Fill(int size) {
    int[] array = new int[size];
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++) {
        array[i] = rand.Next(0, 500);
    }
    return array;
}

// Console.Write("Размер массива: ");
int s = 123;
int[] array = Fill(s);
Console.WriteLine(string.Join(", ", array));
int count = 0;
for (int i = 0; i < s; i++) {
    if(array[i] >= 10 && array[i] <= 99) {
        count++;
    }
}
Console.Write($"Количество элементов из отрезка [10;99]: {count}");
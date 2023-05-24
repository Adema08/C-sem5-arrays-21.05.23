// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
int[] mult = new int[s / 2 + s % 2];
for(int i = 0; i < s / 2; i++) {
    mult[i] = array[i] * array[s - 1 - i];
}
if(s % 2 == 1) {
    mult[s / 2] = array[s / 2];
}
Console.WriteLine(string.Join(", ", mult));
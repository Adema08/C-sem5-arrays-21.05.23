// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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
Console.Write("Введите число: ");
int find = Convert.ToInt32(Console.ReadLine());
int count = 0;
for(int i = 0; i < array.Length; i++) {
    if(array[i] == find) {
        count++;
        break;
    }
}
if (count != 0) {
    Console.Write("Данное число присутствует в массиве");
}
else {
    Console.Write("Данное число отсутствует в массиве");
}
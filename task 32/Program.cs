// Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
for(int i = 0; i < array.Length; i++) {
    array[i] *= -1;
}
Console.WriteLine(string.Join(", ", array));

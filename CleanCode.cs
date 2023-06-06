using System;
public class CleanCode {
    public static void Main() {
        int[] array = {
            10,
            5,
            1,
            7,
            2
        };

        Console.WriteLine("Array:");
        foreach(int p in array)
        Console.WriteLine(p + " ");

        Console.WriteLine("Sorted Array:");
        foreach(int p in BubbleSort(array))
        Console.WriteLine(p + " ");

        Console.Read();
    }

    public static int[] BubbleSort(int[] arr) {
        int temp;
        for (int j = 0; j < arr.Length - 1; j++) {
            for (int i = 0; i < arr.Length - 1; i++) {
                if (arr[i] > arr[i + 1]) {
                    temp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        return arr;
    }
}

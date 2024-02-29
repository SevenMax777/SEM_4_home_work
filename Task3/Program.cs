int[] array = { 1, 2, 3, 4, 5 };

for (int i = 0; i < array.Length / 2; i++)
{
	int temp = array[i];
	array[i] = array[array.Length - 1 - i];
	array[array.Length - 1 - i] = temp;
}

foreach (int element in array)
{
   Console.Write(element + " ");
}

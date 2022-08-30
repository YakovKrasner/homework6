int NumbersAmount = 7;
int [] Array = new int [NumbersAmount];
int PositiveNumberAmount = 0;
for (int i = 0; i < Array.Length; i++)
    {
Console.WriteLine ($"Введите элемент массива под номером {i}");
Array [i] = Convert.ToInt32(Console.ReadLine ());
    }
for (int i = 0; i < Array.Length; i++)
    {
        if (Array [i] > 0) PositiveNumberAmount ++;
    }
Console.WriteLine ($"Количество чисел больше ноля равно {PositiveNumberAmount}");


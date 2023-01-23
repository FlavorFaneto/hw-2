// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите целое число:");
var input = Console.ReadLine();
ulong number1 = 1;
bool indikatorULONG = false;
if (!long.TryParse(input, out var number))
{
    var number2 = number;
    indikatorULONG = true;
}
if (!ulong.TryParse(input, out number1))
{
    Console.WriteLine($"Введенное значение не распознано как целое число! Выполнение прервано");
    var number3 = number1;
    return;
}

// 1 sbyte
if (number >= sbyte.MinValue && number <= sbyte.MaxValue && !indikatorULONG)
{
    Console.WriteLine(
        $"Исходное число {number}, приведенное к {typeof(sbyte)} == {(sbyte)number}");
}
else
{
    Console.WriteLine($"Для приведения числа {number} к типу {typeof(sbyte)} число не может быть больше {sbyte.MaxValue} и меньше {sbyte.MinValue}");
}

// 2 int
if (number >= int.MinValue && number <= int.MaxValue && !indikatorULONG)
{
    Console.WriteLine(
        $"Исходное число {number}, приведенное к {typeof(int)} == {(int)number}");
}
else
{
    Console.WriteLine(
        $"Для приведения числа {number} к типу {typeof(int)} число не может быть больше {int.MaxValue} и меньше {int.MinValue}");
}

// ctrl+c ctrl+v for short, long, byte, ushort, unit, ulong
// 3 short
if (number >= short.MinValue && number <= short.MaxValue && !indikatorULONG)
{
    Console.WriteLine(
        $"Исходное число {number}, приведенное к {typeof(short)} == {(short)number}");
}
else
{
    Console.WriteLine($"Для приведения числа {number} к типу {typeof(short)} число не может быть больше {short.MaxValue} и меньше {short.MinValue}");
}
//4 long
if (number >= long.MinValue && number <= long.MaxValue && !indikatorULONG)
{
    Console.WriteLine(
        $"Исходное число {number}, приведенное к {typeof(long)} == {(long)number}");
}
else
{
    Console.WriteLine($"Для приведения числа {number} к типу {typeof(long)} число не может быть больше {long.MaxValue} и меньше {long.MinValue}");
}
//5 byte
if (number >= byte.MinValue && number <= byte.MaxValue && !indikatorULONG)
{
    Console.WriteLine(
        $"Исходное число {number}, приведенное к {typeof(byte)} == {(byte)number}");
}
else
{
    Console.WriteLine($"Для приведения числа {number} к типу {typeof(byte)} число не может быть больше {byte.MaxValue} и меньше {byte.MinValue}");
}//6 ushort
if (number >= ushort.MinValue && number <= ushort.MaxValue && !indikatorULONG)
{
    Console.WriteLine(
        $"Исходное число {number}, приведенное к {typeof(ushort)} == {(ushort)number}");
}
else
{
    Console.WriteLine($"Для приведения числа {number} к типу {typeof(ushort)} число не может быть больше {ushort.MaxValue} и меньше {ushort.MinValue}");
}

//7 uint

if (number >= uint.MinValue && number <= uint.MaxValue && !indikatorULONG)
{
    Console.WriteLine(
        $"Исходное число {number}, приведенное к {typeof(uint)} == {(uint)number}");
}
else
{
    Console.WriteLine($"Для приведения числа {number} к типу {typeof(uint)} число не может быть больше {uint.MaxValue} и меньше {uint.MinValue}");
}
//8 ulong
if (number1 >= ulong.MinValue && number1 <= ulong.MaxValue)
{
    Console.WriteLine(
        $"Исходное число {number1}, приведенное к {typeof(ulong)} == {(ulong)number1}");
}
else
{
    Console.WriteLine($"Для приведения числа {number1} к типу {typeof(ulong)} число не может быть больше {ulong.MaxValue} и меньше {ulong.MinValue}");
}


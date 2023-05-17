int a = 5;
int b = 6;

add(a, b);
add(12, 123);
add(2423, 2523);

Multiply(a, b);
Multiply(35, 27);
Multiply(232, 23);

substract(a, b);
substract(25, 7);
substract(33, 3);


divided(b, a);
divided(27, 3);
divided(23, 2);
static void add(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}

static void Multiply(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}

static void substract(int x, int y)
{
    Console.WriteLine($"{x} - {y} = {x - y}");
}
static void divided(int x, int y)
{
    Console.WriteLine($"{x} / {y} = {x / y}");
}
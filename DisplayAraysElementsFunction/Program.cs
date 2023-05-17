string[] fruitBasket = { "apples", "bananas", "oranges" };
string[] pets = { "cats", "dogs", "fish" };
string[] guys = { "yavuz", "selim" };
string[] numbers = { "1", "2", "3" };


PrintArrayElements(fruitBasket);
PrintArrayElements(pets);
PrintArrayElements(guys);
PrintArrayElements(numbers);

static void PrintArrayElements(string[] someArray)
{
    for (int i = 0; i < someArray.Length; i++)
    {
        Console.WriteLine($"{i + 1} {someArray[i]}");
    }

}
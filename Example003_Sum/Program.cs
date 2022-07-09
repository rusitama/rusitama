System.Random random = new System.Random();
int numberA = random.Next(1, 10);
Console.WriteLine(numberA);
int numberB = random.Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
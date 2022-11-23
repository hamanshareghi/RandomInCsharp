

// See https://aka.ms/new-console-template for more information
Random random =new Random();
for (int i = 0; i < 10; i++)
	{
		var randomNumber = GenerateIntRandom(random);
		Console.WriteLine(randomNumber);
	}
for (int i = 0; i < 10; i++)
{
	var randomString = GenerateStringRandom(random,10);
	Console.WriteLine(randomString);
}
for (int i = 0; i < 10; i++)
{
	var randomColor = GenerateHexColorCode(random);
	Console.WriteLine(randomColor);
}
Console.WriteLine("Pres Any Key For Exit ... ");

int GenerateIntRandom(Random random)
{
	var randomNumber = random.Next(100,1000);
	return randomNumber;
	
}

static string GenerateStringRandom(Random random, int stringLength)
{
	const string allowCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!&_@1234567890";
	var randomString = new string(Enumerable.Repeat(allowCharacters, stringLength)
		.Select(s => s[random.Next(s.Length)]).ToArray()
	);
	return randomString;
}

static string GenerateHexColorCode(Random random)
{
	var color = string.Format("#{0:X6}", random.Next(0x1000000));
	return color;
}
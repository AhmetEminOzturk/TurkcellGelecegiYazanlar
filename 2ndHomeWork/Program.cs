var password = string.Empty;
while (password.Length < 6)
{
    Console.WriteLine("Enter a password with minimum 6 Digit");
    password = Console.ReadLine();
    if (password.Length >= 6)
        break;
    else
        continue;
}


List<char> characters = new List<char>();
foreach (var item in password)
    characters.Add(item);


int isNumber = 0;
int isChar = 0;
foreach (var item in characters)
{
    if (char.IsNumber(item))
        isNumber++;
    if (char.IsLetter(item))
        isChar++;
}

Console.WriteLine(isNumber == characters.Count ? "Weak Password" : isChar == characters.Count ? "Weak Password" : (isChar + isNumber) == characters.Count ? "Avarage Password" : "Strong Password");
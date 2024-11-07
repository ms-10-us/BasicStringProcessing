Console.WriteLine("Description 1:");

Console.WriteLine();

string userAnswer = "y";

while (userAnswer.ToLower().Trim() == "y")
{
    Console.WriteLine("Please enter a sentence");
    string sentence = Console.ReadLine();
    string word = "";
    foreach (char character in sentence)
    {
        if (character != ' ')
        {
            word += character; 
        }
        else if (character == ' ' || character == '.' || character == '?' || character == '!')
        {
            Console.WriteLine(word);
            word = string.Empty;
        }
    }
    Console.WriteLine(word);

    Console.WriteLine("Would you like to continue (y/n)?");
    userAnswer = Console.ReadLine();
}

if (userAnswer.ToLower().Trim() == "n")
{
    Console.WriteLine("Goodbye!");
}

Console.WriteLine();

Console.WriteLine("Description 2");

Console.WriteLine();

userAnswer = "y";
List<string> userList = new List<string>();

while (userAnswer.ToLower().Trim() == "y")
{
    Console.WriteLine("Please enter some text");
    string userWord = Console.ReadLine();
    userList.Add(userWord);
    string sentence = "";
    foreach (string wordInList in userList)
    {
        sentence = sentence + wordInList + " ";
    }

    Console.WriteLine($"You have entered: {sentence}");
    sentence = string.Empty;
    Console.WriteLine("Would you like to continue? (y/n)");
    userAnswer = Console.ReadLine();
}

if (userAnswer.ToLower().Trim() == "n")
{
    Console.WriteLine("Goodbye!");
}





















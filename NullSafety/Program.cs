// https://learn.microsoft.com/en-us/dotnet/csharp/nullable-references
// https://csvelocity.wordpress.com/2021/08/27/c-null-tip/

string message = "Hello, World!";
int length = message.Length; // dereferencing "message"

Console.WriteLine(length);

//message = null;
//Console.WriteLine(message.Length); // NullReferenceException

string? message2 = null;
string? input = Console.ReadLine();
if (input?.Length > 2)
{
    message2 = input;
}

Console.WriteLine("message2?.length: " + message2?.Length); // NullReferenceException

int? number = 14593;
Console.WriteLine(number);
number = null;
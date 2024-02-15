// Задайте строку, содержащую латинские буквы в обоих регистрах.
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.

//“aBcD1ef!-” => “abcd1ef!-”

//char[] ch_array = { 'a', 'B', 'c', 'D','l', 'e', 'f', '!', '-' };


//Console.Write("Введите символы: ");

//char[] ch_array = Console.ReadLine(); 
Console.WriteLine("Input High and Low Case Lat Symbols");
string input = Console.ReadLine(); 
Console.WriteLine("Input:");
Console.WriteLine(input);
Console.WriteLine("To Lower:");
Console.WriteLine(input.ToLower());
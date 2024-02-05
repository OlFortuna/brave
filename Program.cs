// // Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// int number = 453;
// int firstDigit = number / 100; // 453 / 100 = 4
// int thirdDigit = number % 10; // 453 % 10 = 3
// int result = firstDigit * 10 + thirdDigit; // 4 * 10 + 3 = 43
// // $"Текст {result} текст {a+100} текст {a - 500}"
// Console.WriteLine($"В числе {number} => {result}");



// git commit -am "added first task"

// git add . (-a)
// git commit -m "added first task"



// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

int number = 947;
int seсondDigit = number / 10 % 10; // 947 / 10 % 10 = 94 % 10 = 4 
int thirdDigit = number % 10; // 947 % 10 = 7
// Math.Pow(5, 2) => 5^2 = 5*5=25
int result = (int)Math.Pow(seсondDigit, thirdDigit);
// Результат переводится в (int)
Console.WriteLine($"{seсondDigit} ^ {thirdDigit} = {result}");
// 4 ^ 7 =
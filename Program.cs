//try
//{
//    int x = 5;
//    int y = x / 0;
//    Console.WriteLine(y);
//}
//catch
//{
//    Console.WriteLine("Возникло исключение!");
//}
//finally
//{
//    Console.WriteLine("Блок finally");
//}
//
//Console.WriteLine("Конец программы");
//
//try
//{
//    int x = Convert.ToInt32(Console.ReadLine());
//    int y = x / 0;
//    Console.WriteLine($"Результат: {y}");
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}
//catch (FormatException ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Произошла ошибка: {ex.Message}");
//}
//
//Console.WriteLine("Конец программы");
//
// Исправленный код
//while (true)
//{
//    try
//    {
//        Console.Write("Введите первое число: ");
//        string input1 = Console.ReadLine() ?? "";
//        if (string.IsNullOrWhiteSpace(input1))
//        {
//            Console.WriteLine("Ошибка: Введена пустая строка");
//            continue;
//        }
//        double number1 = Convert.ToDouble(input1); // ИСПРАВЛЕНО: Добавлена проверка на пустую строку
//        
//        Console.Write("Введите второе число: ");
//        string input2 = Console.ReadLine() ?? "";
//        if (string.IsNullOrWhiteSpace(input2))
//        {
//            Console.WriteLine("Ошибка: Введена пустая строка");
//            continue;
//        }
//        double number2 = Convert.ToDouble(input2); // ИСПРАВЛЕНО: Добавлена проверка на пустую строку
//        
//        Console.Write("Введите операцию (+, -, *, /): ");
//        string? op = Console.ReadLine();
//        
//        double result = 0;
//        
//       switch (op)
//        {
//            case "+": 
//                result = number1 + number2; // ИСПРАВЛЕНО: Складываем number1 и number2
//            case "-": 
//                result = number1 - number2; 
//                break;
//            case "*": 
//                result = number1 * number2; 
//                break;
//            case "/":
//                if (number2 == 0) // ИСПРАВЛЕНО: Добавлена проверка на ноль
//                {
//                    Console.WriteLine("Ошибка: Нельзя делить на ноль!");
//                    continue;
//                }
//                result = number1 / number2; 
//                break;
//            default: 
//                Console.WriteLine("Неизвестная операция!"); 
//                continue;
//        }
//        
//        Console.WriteLine($"Результат: {result}"); // ИСПРАВЛЕНО: Используем инициализированную переменную
//    }
//    catch (FormatException)
//    {
//        Console.WriteLine("Ошибка ввода! Введите корректные числа.");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
//    }
//    
//    Console.Write("Продолжить? (y/n): ");
//    string? answer = Console.ReadLine();
//    if (answer?.ToLower() != "y") // ИСПРАВЛЕНО: Правильное условие выхода
//    {
//        Console.WriteLine("Работа калькулятора завершена.");
//        break;
//    }
//}
//
//int number = 12;
//Console.WriteLine(number.ToString());
//bool boolean = true;
//Console.WriteLine(boolean.ToString());
//DateTime now = DateTime.Now;
//Console.WriteLine(now.ToString());
//object me = new();
//Console.WriteLine(me.ToString());
//
//int age = int.Parse("27");
//DateTime birthday = DateTime.Parse("4 July 1980");
//Console.WriteLine($"I was born {age} years ago.");
//Console.WriteLine($"My birthday is {birthday}.");
//Console.WriteLine($"My birthday is {birthday:D}.");
//
//int count = int.Parse("abc");
//
//Console.Write("Какой максимальный балл по дисциплинам? ");
//string? input = Console.ReadLine();
//if (int.TryParse(input, out int count2))
//{
//    Console.WriteLine($"Это {count2} баллов.");
//}
//else
//{
//    Console.WriteLine("Некорректный ввод.");
//}
//
//Console.Write("Введите сумму: ");
//string? amount = Console.ReadLine();
//try
//{
//    decimal amountValue = decimal.Parse(amount);
//}
//catch (FormatException) when (amount.Contains("$"))
//{
//    Console.WriteLine("В суммах нельзя использовать знак доллара!");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Суммы должны содержать только цифры!");
//}
//
//int x = int.MaxValue - 1;
//Console.WriteLine($"Initial value: {x}");
//x++;
//Console.WriteLine($"After incrementing: {x}");
//x++;
//Console.WriteLine($"After incrementing: {x}");
//x++;
//Console.WriteLine($"After incrementing: {x}");
//
//checked
//{
//    int x2 = int.MaxValue - 1;
//    Console.WriteLine($"Initial value: {x2}");
//    x2++;
//    Console.WriteLine($"After incrementing: {x2}");
//    x2++;
//    Console.WriteLine($"After incrementing: {x2}");
//    x2++;
//    Console.WriteLine($"After incrementing: {x2}");
//}
//
//try
//{
//    checked
//    {
//        int x3 = int.MaxValue - 1;
//        Console.WriteLine($"Initial value: {x3}");
//        x3++;
//        Console.WriteLine($"After incrementing: {x3}");
//        x3++;
//        Console.WriteLine($"After incrementing: {x3}");
//        x3++;
//        Console.WriteLine($"After incrementing: {x3}");
//    }
//}
//catch (OverflowException)
//{
//    Console.WriteLine("The code overflowed but I caught the exception.");
//}
//
//static double Add(double a, double b)
//{
//    return a * b;
//}
//
//double a = 4.5;
//double b = 2.5;
//double answer = Add(a, b);
//Console.WriteLine($"{a} + {b} = {answer}");
//Console.WriteLine("Нажмите ENTER чтобы продолжить.");

//Console.ReadLine();

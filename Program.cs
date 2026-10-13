// // // // // Задание 1.1. Обратный отсчёт от 10 до 1
// // // // for (int i = 10; i >= 1; i--)
// // // // {
// // // //     Console.Write(i + " ");
// // // // }
// // // // Console.WriteLine(); // для переноса строки


// // // // // Задание 1.2. Чётные числа от 1 до 50
// // // // // Способ с шагом i += 2
// // // // for (int i = 2; i <= 50; i += 2)
// // // // {
// // // //     Console.Write(i + " ");
// // // // }
// // // // Console.WriteLine();


// // // // Задание 2
// // // int sumOfThrees = 0; // сумма кратных 3
// // // int countOfSevens = 0; // количество делящихся на 7

// // // for (int i = 1; i <= 100; i++)
// // // {
// // //     if (i % 3 == 0)
// // //     {
// // //         sumOfThrees += i;
// // //     }
// // //     if (i % 7 == 0)
// // //     {
// // //         countOfSevens++;
// // //     }
// // // }

// // // Console.WriteLine($"Сумма чисел, кратных 3: {sumOfThrees}"); 
// // // Console.WriteLine($"Количество чисел, делящихся на 7: {countOfSevens}"); 


// // // Задание 3
// // int positiveCount = 0;
// // int negativeCount = 0;

// // Console.WriteLine("Вводите числа (0 для окончания ввода):");
// // int number = Convert.ToInt32(Console.ReadLine());

// // while (number != 0)
// // {
// //     if (number > 0)
// //     {
// //         positiveCount++;
// //     }
// //     else if (number < 0)
// //     {
// //         negativeCount++;
// //     }

// //     number = Convert.ToInt32(Console.ReadLine());
// // }

// // Console.WriteLine($"Положительных чисел: {positiveCount}");
// // Console.WriteLine($"Отрицательных чисел: {negativeCount}");

// // Задание 4
// string correctPassword = "qwerty";
// bool isAccessGranted = false;

// for (int attempt = 1; attempt <= 2; attempt++)
// {
//     Console.Write("Введите пароль: ");
//     string password = Console.ReadLine();

//     if (password == correctPassword)
//     {
//         isAccessGranted = true;
//         break; 
//     }
// }

// if (isAccessGranted)
// {
//     Console.WriteLine("Доступ разрешён");
// }
// else
// {
//     Console.WriteLine("Доступ заблокирован");
// }

// Задание 5. Таблица умножения
Console.Write("Введите число n (от 1 до 9): ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
}


// Задание 6. Числа без троек
for (int i = 1; i <= 30; i++)
{
    if (i % 3 == 0)
    {
        continue; 
    }
    
    if (i > 20 && i % 10 == 0)
    {
        break; // 
    }
    
    Console.Write(i + " ");
}
Console.WriteLine();

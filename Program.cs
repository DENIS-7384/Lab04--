// int age = 60;
// if (age < 13) {
//     Console.WriteLine("Ребёнок");
// } else if (age < 18) {
//     Console.WriteLine("Подросток");
// } else if (age >= 60) {
//     Console.WriteLine("Пенсионер");
// } else {
//     Console.WriteLine("Взрослый");
// }

// int age = 16;
// double height = 1.4;
// bool hasAdultSupervision = true;
// if ((age >= 14 && height >= 1.5) || (height < 1.5 && hasAdultSupervision)) {
//     Console.WriteLine("Можно кататься");
// } else {
//     Console.WriteLine("Пока нельзя");
// }

// int n = int.Parse(Console.ReadLine());
// if (n % 2 == 0) {
//     Console.WriteLine("Чётное");
// } else {
//     Console.WriteLine("Нечётное");
// }

// int mark = int.Parse(Console.ReadLine());
// switch (mark) {
//     case 5:
//         Console.WriteLine("Отлично");
//         break;
//     case 4:
//         Console.WriteLine("Хорошо");
//         break;
//     case 3:
//         Console.WriteLine("Удовлетворительно");
//         break;
//     case 2:
//         Console.WriteLine("Неудовлетворительно");
//         break;
//     default:
//         Console.WriteLine("Неверная оценка");
//         break;
// }



Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();

if (string.IsNullOrEmpty(surname))
{
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}

Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

var assigned = Enumerable.Range(1, 10)
    .OrderBy(_ => rnd.Next())
    .Take(2)
    .OrderBy(x => x)
    .ToList();

Console.WriteLine($"Задачи: №{assigned} и №{assigned}");



















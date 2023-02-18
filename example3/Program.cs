// воод строки 
int promt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
// ограничение данных - будние дни
bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}
// ограничение данных "не день недели"
bool ValidateWeekDay(int weekDay)
{
    if (weekDay > 0) 
    if (weekDay <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели!");
    return false;
}
// воод данных пользователем 
int weekDay = promt("Введите день недели: "); 
// определитель дня недели
if (ValidateWeekDay(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Ура, выходной!");
    }
    else
    {
        Console.WriteLine("Эх, ещё работать и работать...");
    }
}

int dayNamber = Convert.ToInt32(Console.ReadLine());
if (dayNamber>=1 && dayNamber <=7 )
{
    if (dayNamber == 1 )
    {
         Console.WriteLine("Понедельник");
    }
    if (dayNamber == 2 )
    {
         Console.WriteLine("Вторник");
    }
    if (dayNamber == 3 )
    {
         Console.WriteLine("Среда");
    }
    if (dayNamber == 4 )
    {
         Console.WriteLine("Четверг");
    }
    if (dayNamber == 5 )
    {
         Console.WriteLine("Пятница");
    }
    if (dayNamber == 6 )
    {
         Console.WriteLine("Суббота");
    }
    if (dayNamber == 7 )
    {
         Console.WriteLine("Воскресенье");
    }
}
else
{
     Console.WriteLine("Error 404, day not found");
}
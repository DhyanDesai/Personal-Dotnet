namespace Personal_Dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            EqualOrNot eq1 = new EqualOrNot();
            eq1.Equal();
            SignCheck s1 = new SignCheck();
            s1.sign();
            WeekDay wd1 = new WeekDay();
            wd1.weekday();
        }
    }
}
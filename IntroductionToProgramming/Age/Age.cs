namespace Age
{
    using System;

    class Age
    {
        static void Main()
        {
            int myAge;

            DateTime myBirthDate = DateTime.Parse(Console.ReadLine());
            DateTime currentDate = DateTime.Now;

            myAge = currentDate.Year - myBirthDate.Year;

            if (currentDate.Month <= myBirthDate.Month || currentDate.Day<=myBirthDate.Day)
            {
                myAge--;
            }
            Console.WriteLine(myAge);
            Console.WriteLine(myAge + 10);
        }
    }
}

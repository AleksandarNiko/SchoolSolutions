using System;

public class EGNHuman
{
    private string eGN;

    public string EGN { get => eGN; set 
       {
            if (value.Length != 10)
            {
                throw new ArgumentException("ЕГН трябва да съдържа точно 10 цифри.");
            }
             eGN = value;
        }
    }

    public EGNHuman(string egn)
    {
       EGN= egn;
    }

    public bool IsValid()
    {
        if (EGN.Length != 10) 
        {
            return false;
        }

        int[] weights = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
        int sum = 0;

        for (int i = 0; i < 9; i++)
        {
            var currDigit = int.Parse(EGN[i].ToString());
            sum += currDigit * weights[i];
        }

        int controlDigit = sum % 11;
        if (controlDigit == 10) 
        {
            controlDigit = 0; 
        }

        return (controlDigit == int.Parse(EGN[9].ToString())) ? true : false;
    }

    public string GetGender()
    {
        int genderDigit = int.Parse(EGN[8].ToString());

        return (genderDigit % 2 == 0) ? "Мъж" : "Жена";
    }

    public string GetBirthDate()
    {
        int year = int.Parse(EGN.Substring(0, 2));
        int month = int.Parse(EGN.Substring(2, 2));
        int day = int.Parse(EGN.Substring(4, 2));

        if (month > 20)
        {
            month -= 40;
            year += 2000;
        }
        else if (month > 0 && month <= 20)
        {
            month -= 20;
            year += 1900;
        }

        var birthDate = new DateTime(year, month, day);

        return birthDate.ToString("dd.MM.yyyy");
    }
}

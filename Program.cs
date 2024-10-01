using System;

class Student
{
    private readonly int[] grades = new int[10]; // Масив для зберігання 10 оцінок

    // Індексатор для доступу до оцінок
    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < grades.Length)
            {
                return grades[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Неправильний індекс");
            }
        }
        set
        {
            if (index >= 0 && index < grades.Length)
            {
                if (value >= 0 && value <= 100) // Оцінки мають бути в межах від 0 до 100
                {
                    grades[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Оцінка повинна бути від 0 до 100");
                }
            }
            else
            {
                throw new IndexOutOfRangeException("Неправильний індекс");
            }
        }
    }

    // Метод для розрахунку середнього рейтингу
    public double CalculateAverage()
    {
        int sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        return (double)sum / grades.Length;
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        // Ініціалізація оцінок через індексатор
        student[0] = 85;
        student[1] = 90;
        student[2] = 78;
        student[3] = 92;
        student[4] = 88;
        student[5] = 79;
        student[6] = 95;
        student[7] = 87;
        student[8] = 80;
        student[9] = 91;

        // Виведення середнього рейтингу студента
        double averageGrade = student.CalculateAverage();
        Console.WriteLine($"Середній рейтинг студента: {averageGrade:F2}");
    }
}

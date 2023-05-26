namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = GetDataStudent();
            ShowDataStudent(data);
            Console.ReadLine();
        }

        static (string Name, string FirstName, int Age, string[] StudentPets, string[] StudentColors) GetDataStudent()
        {
            int intValue;
            string stringValue;

            (string Name, string FirstName, int Age, string[] StudentPets, string[] StudentColors) Student;
            Console.WriteLine("Введите Имя");
            Student.Name = CheckStringValue(out stringValue);
            Console.WriteLine("Введите Фамилию");
            Student.FirstName = CheckStringValue(out stringValue);
            Console.WriteLine("Введите Возраст");
            Student.Age = CheckIntValue(out intValue);
            Console.WriteLine("Есть ли у вас питомец");
            string Pet = CheckStringValue(out stringValue);
            Student.StudentPets = Pets(Pet);
            Console.WriteLine("Количество любимых цветов");
            int Color = CheckIntValue(out intValue);
            Student.StudentColors = Colors(Color);
            return Student;
        }
        static void ShowDataStudent((string Name, string FirstName, int Age, string[] StudentPets, string[] StudentColors) Student)
        {

            Console.WriteLine($"Имя: {Student.Name}");
            Console.WriteLine($"Фамилия: {Student.Name}");
            Console.WriteLine($"Возраст: {Student.Name}");
            Console.WriteLine("Клички питомцев:");
            for (int i = 0; i < Student.StudentPets.Length; i++)
            {
                Console.WriteLine($"{Student.StudentPets[i]}");
            }
            Console.WriteLine($"Любимые цвета:");
            for (int i = 0; i < Student.StudentColors.Length; i++)
            {
                Console.WriteLine($"{Student.StudentColors[i]}");
            }
            Console.WriteLine("");


        }
        static string[] Pets(string Pet)
        {
            int intValue;
            string stringValue;
            if (Pet == "Да")
            {
                Console.WriteLine("Сколько?");
                int PetCount = CheckIntValue(out intValue);
                string[] Pets = new string[PetCount];
                for (int i = 0; i < PetCount; i++)
                {
                    Console.WriteLine($"Кличка {i + 1} питомца");
                    Pets[i] = CheckStringValue(out stringValue);
                }
                return Pets;


            }
            else
            {
                Console.WriteLine("очень жаль");
                string[] Pets = new string[] { "Питомцев нет" };
                return Pets;
            }
        }
        static string[] Colors(int ColorCount)
        {
            string stringValue;
            string[] Colors = new string[ColorCount];
            for (int i = 0; i < ColorCount; i++)
            {
                Console.WriteLine($"Ваш {i + 1} любимый цвет");
                Colors[i] = CheckStringValue(out stringValue);
            }
            return Colors;

        }

        static int CheckIntValue(out int CorrectValue)
        {
            var value = Console.ReadLine();
            int numValue;
            bool isNumber = int.TryParse(value, out numValue);
            while (!isNumber)
            {
                Console.WriteLine("Значение не число, попробуйте ввести еще раз");
                value = Console.ReadLine();
                isNumber = int.TryParse(value, out numValue);
            }
            return CorrectValue = Convert.ToInt32(value);
        }

        static string CheckStringValue(out string CorrectValue)
        {
            var value = Console.ReadLine();
            int numValue;
            bool isNumber = int.TryParse(value, out numValue);
            while (isNumber)
            {
                Console.WriteLine("В значении не должно быть чисел");
                value = Console.ReadLine();
                isNumber = int.TryParse(value, out numValue);
            }
            return CorrectValue = value;
        }

    }
}
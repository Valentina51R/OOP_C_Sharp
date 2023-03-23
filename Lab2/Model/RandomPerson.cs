

namespace Model
{
    /// <summary>
    /// Класс для создания
    /// рандомного человека.
    /// </summary>
    public class RandomPerson
    {
        /// <summary>
        /// Рандом.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Массив строк мужских имён
        /// </summary>
        private static string[] _menNames = {
                "Damon", "Jeremy", "Matt", "Tyler",
                "Klaus", "Stefan", "Richard", "Kol" };

        /// <summary>
        /// Массив строк женских имён
        /// </summary>
        private static string[] _wemenNames = {
                "Elena", "Katherine", "Jenna", "Bonnie",
                "Caroline", "Vicki", "Rebekah", "Lexi" };

        /// <summary>
        /// Массив строк фамилий
        /// </summary>
        private static string[] _surnames = {
                "Bennet", "Gilbert", "Pierce", "Salvatore",
                "Sommers", "Forbes", "Donovan", "Lockwood" };

        /// <summary>
        /// Метод создания взрослого или ребёнка
        /// </summary>
        /// <returns></returns>
        public static PersonBase GetRandomAnyPerson()
        {
            var who = _random.Next(0, 2);
            if (who > 0)
            {
                return GetRandomChild();
            }
            else
            {
                return GetRandomAdult();
            }
        }

        /// <summary>
        /// Создание рандомного человека
        /// </summary>
        /// <returns></returns>
        public static void GetRandomPerson(PersonBase person,
            Gender gender = Gender.Default)
        {

            if (gender == Gender.Default)
            {
                person.Gender = (Gender)_random.Next(2);
            }
            else
            {
                person.Gender = gender;
            }

            if (person.Gender == Gender.Male)
            {
                person.Name = _menNames[_random.Next(1, _menNames.Length)];
            }
            else
            {
                person.Name = _wemenNames[_random.Next(1, _wemenNames.Length)];
            }
            person.Surname = _surnames[_random.Next(1, _surnames.Length)];

        }

        /// <summary>
        /// Создание рандомного взрослого
        /// </summary>
        /// <returns></returns>
        public static Adult GetRandomAdult(MaritalStatus status = MaritalStatus.Single,
            Adult partner = null, Gender gender = Gender.Default)
        {
            Adult randomAdult = new Adult();
            GetRandomPerson(randomAdult, gender);

            randomAdult.Age = _random.Next(randomAdult.MinAge, randomAdult.MaxAge);

            MaritalStatus maritalstatus = (MaritalStatus)_random.Next(2);
            randomAdult.MaritalStatus = maritalstatus;

            if (maritalstatus == MaritalStatus.Married)
            {
                if (randomAdult.Gender == Gender.Male)
                {
                    randomAdult.Partner = GetRandomAdult(
                        MaritalStatus.Married, randomAdult, Gender.Female);
                }
                else
                {
                    randomAdult.Partner = GetRandomAdult(
                        MaritalStatus.Married, randomAdult, Gender.Male);
                }
            }
            else
            {
                randomAdult.MaritalStatus = status;
            }

            string[] job = { "SO \"UES\" ", "RusGidro", "Sberbank",
                "Bakery \"Plump bun\"", "Norilsk Nickel", "Rosbank" };

            var getjob = _random.Next(0, 4);

            if (getjob > 0)
            {
                randomAdult.Job = job[_random.Next(0, job.Length)];
            }

            var passport = (uint)_random.Next
                (Adult.MinPassportNumber, Adult.MaxPassportNumber);
            randomAdult.Рassport = passport;

            return randomAdult;
        }

        /// <summary>
        /// Метод создания рандомного ребёнка.
        /// </summary>
        /// <returns></returns>
        public static Child GetRandomChild()
        {
            Child randomChild = new Child();
            GetRandomPerson(randomChild);

            randomChild.Age = _random.Next
                (randomChild.MinAge, randomChild.MaxAge);

            var mother = _random.Next(0, 4);

            if (mother > 0)
            {
                randomChild.Mother = GetRandomAdult
                    (MaritalStatus.Married, randomChild.Father, Gender.Female);
            }

            var fathert = _random.Next(0, 4);

            if (fathert > 0)
            {
                randomChild.Father = GetRandomAdult
                    (MaritalStatus.Married, randomChild.Mother, Gender.Male);
            }

            string[] kindergarten = {
                "Kindergarten \"Rucheek\"", "Kindergarten \"Dandelion\"",
                "Kindergarten \"Sunny\"", "Kindergarten \"Cucumbers\"" };

            string[] school = {
                "Forks High School", "The Cambridge School of Weston",
                "Mystic Falls High School", "Beacon Hills High School" };

            var hasInstitution = _random.Next(0, 4);

            if (hasInstitution > 0)
            {
                if (randomChild.Age < 8)
                {
                    randomChild.Institution = kindergarten
                        [_random.Next(1, kindergarten.Length)];
                }
                else
                {
                    randomChild.Institution = school
                        [_random.Next(1, school.Length)];
                }
            }

            return randomChild;
        }
    }
}

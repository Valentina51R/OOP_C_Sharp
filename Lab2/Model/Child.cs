

namespace Model
{
    /// <summary>
    /// Класс для описания ребёнка.
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Минимальный возраст.
        /// </summary>
        public override int MinAge => 0;

        /// <summary>
        /// Максимальный возраст.
        /// </summary>
        public override int MaxAge => 17;

        /// <summary>
        /// Садик / школа.
        /// </summary>
        private string? _institution;

        /// <summary>
        /// Ввод возраста ребёнка.
        /// </summary>
        public override int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > MaxAge || value < MinAge)
                {
                    throw new ArgumentException($"Введён некорректный" +
                        $" возвраст ребёнка, введите возраст" +
                        $" от {MinAge} до {MaxAge} лет!");
                }
                else
                {
                    _age = value;
                }
            }
        }

        /// <summary>
        /// Задание матери.
        /// </summary>
        public Adult? Mother { get; set; }


        /// <summary>
        /// Задание отца.
        /// </summary>
        public Adult? Father { get; set; }


        /// <summary>
        /// Задание детсада/школы.
        /// </summary>
        public string Institution
        {
            get
            {
                return _institution;
            }
            set
            {
                _institution = value;
            }
        }

        /// <summary>
        /// Проверка есть ли родитель.
        /// </summary>
        /// <param name="perent">Партнёр.</param>
        /// <param name="who">Строка.</param>
        /// <returns>Информация о родителе в виде строки.</returns>
        private static string CheckParents(Adult? perent, string who = "Mother")
        {
            if (perent != null)
            {
                return $"\n{who}: {perent.Name} " +
                    $"{perent.Surname}, ";
            }
            else
            {
                return $"\nNo information about the {who}. ";
            }
        }

        /// <summary>
        /// Метод получения информации
        /// </summary>
        /// <returns>Информация о ребёнке.</returns>
        public override string GetInfo()
        {
            string personInfo = base.GetInfo();

            personInfo += CheckParents(Mother, "Mother");
            personInfo += CheckParents(Father, "Father");

            personInfo += "\nPlace of study: ";
            if (string.IsNullOrEmpty(Institution))
            {
                personInfo += "The child is not registered" +
                    " in kindergarten or school.";
            }
            else
            {
                personInfo += Institution;
            }

            return personInfo;
        }

        /// <summary>
        /// Определение любимого блюда ребёнка.
        /// </summary>
        /// <returns>строка.</returns>
        public string Dishes()
        {
            string[] meals = {
                "ice cream", "cake", "steak",
                "chocolate", "soup" };

            string meal = meals[new Random().Next(1, meals.Length)];

            return $"The {Name} {Surname} likes to eat {meal}.";
        }

    }
}

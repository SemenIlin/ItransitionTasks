﻿namespace ItransitionTask3.Address
{
    public class AddressRu : Randomizer, IAddress
    {
        public string Country => "Россия";

        public string[] Cities => new string[]
        {
            "Москва",
            "Владимир",
            "Санкт-Петербург",
            "Новосибирск",
            "Екатеринбург",
            "Нижний Новгород",
            "Самара",
            "Казань",
            "Омск",
            "Челябинск",
            "Ростов-на-Дону",
            "Уфа",
            "Волгоград",
            "Пермь",
            "Красноярск",
            "Воронеж",
            "Саратов",
            "Краснодар",
            "Тольятти",
            "Ижевск",
            "Барнаул",
            "Ульяновск",
            "Тюмень",
            "Иркутск",
            "Владивосток",
            "Ярославль",
            "Хабаровск",
            "Махачкала",
            "Оренбург",
            "Новокузнецк",
            "Томск",
            "Кемерово",
            "Рязань",
            "Астрахань",
            "Пенза",
            "Липецк",
            "Тула",
            "Киров",
            "Чебоксары",
            "Курск",
            "Брянск",
            "Магнитогорск",
            "Иваново",
            "Тверь",
            "Ставрополь",
            "Белгород",
            "Сочи"
        };

        public string[] Streets => new string[]
        {
            "ул.Советская",
            "ул.Молодежная",
            "ул.Центральная",
            "ул.Школьная",
            "ул.Новая",
            "ул.Садовая",
            "ул.Лесная",
            "ул.Набережная",
            "ул.Ленина",
            "ул.Мира",
            "ул.Октябрьская",
            "ул.Зеленая",
            "ул.Комсомольская",
            "ул.Заречная",
            "ул.Первомайская",
            "ул.Гагарина",
            "ул.Полевая",
            "ул.Луговая",
            "ул.Пионерская",
            "ул.Кирова",
            "ул.Юбилейная",
            "ул.Северная",
            "ул.Пролетарская",
            "ул.Степная",
            "ул.Пушкина",
            "ул.Калинина",
            "ул.Южная",
            "ул.Колхозная",
            "ул.Рабочая",
            "ул.Солнечная",
            "ул.Железнодорожная",
            "ул.Восточная",
            "ул.Заводская",
            "ул.Чапаева",
            "ул.Нагорная",
            "ул.Строителей",
            "ул.Береговая",
            "ул.Победы",
            "ул.Горького",
            "ул.Кооперативная",
            "ул.Красноармейская",
            "ул.Совхозная",
            "ул.Речная",
            "ул.Школьный",
            "ул.Спортивная",
            "ул.Озерная",
            "ул.Строительная",
            "ул.Парковая",
            "ул.Чкалова",
            "ул.Мичурина",
            "ул.Подгорная",
            "ул.Дружбы",
            "ул.Почтовая",
            "ул.Партизанская",
            "ул.Вокзальная",
            "ул.Лермонтова",
            "ул.Свободы",
            "ул.Дорожная",
            "ул.Дачная",
            "ул.Маяковского",
            "ул.Западная",
            "ул.Фрунзе",
            "ул.Дзержинского",
            "ул.Московская",
            "ул.Свердлова",
            "ул.Некрасова",
            "ул.Гоголя",
            "ул.Красная",
            "ул.Трудовая",
            "ул.Шоссейная",
            "ул.Чехова",
            "ул.Коммунистическая",
            "ул.Труда",
            "ул.Комарова",
            "ул.Матросова",
            "ул.Островского",
            "ул.Сосновая",
            "ул.Клубная",
            "ул.Куйбышева",
            "ул.Крупской",
            "ул.Березовая",
            "ул.Карла Маркса",
            "ул.8 Марта",
            "ул.Больничная",
            "ул.Садовый",
            "ул.Интернациональная",
            "ул.Суворова",
            "ул.Цветочная",
            "ул.Трактовая",
            "ул.Ломоносова",
            "ул.Горная",
            "ул.Космонавтов",
            "ул.Энергетиков",
            "ул.Шевченко",
            "ул.Весенняя",
            "ул.Механизаторов",
            "ул.Коммунальная",
            "ул.40 лет Победы",
            "ул.Майская"
        };

        public string ZipCode => random.Next(100000,999999).ToString();

        public string NumberHome => "д." + random.Next(1, 300).ToString();

        public string NumberFlat => "кв." + random.Next(1, 300).ToString();
        
        public string Phone => "(948)" + random.Next(1000000,9999999).ToString("###-##-##");
    }
}

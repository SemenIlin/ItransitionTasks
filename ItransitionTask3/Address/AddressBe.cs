﻿namespace ItransitionTask3.Address
{
    public class AddressBe : Randomizer, IAddress
    {
        public string Country => "Беларусь";

        public string[] Cities => new string[]
        {
			"Баранавічы",
			"Іванава",
			"Петрыкаў",
			"Баран",
			"Івацэвічы",
			"Пінск",
			"Белаазёрск",
			"Айві",
			"Полацк",
			"Бялынічы",
			"Пастаў",
			"Бяроза",
			"Калінкавічы",
			"Пружаны",
			"Камянец",
			"Бярозаўка",
			"Кіраўск",
			"Рэчыца",
			"Бабруйск",
			"Клецка",
			"Рагачоў",
			"Клімавічы",
			"Браслаўскі",
			"Клічаў",
			"Светлагорск",
			"Кобрын",
			"Свіслач",
			"Буда-Кашалёва",
			"Капыль",
			"Сена",
			"Быхаў",
			"Косава",
			"Скідаль",
			"Касцюковічы",
			"Слаўгарад",
			"Васілевічы",
			"Крычаў",
			"Слонім",
			"Верхнядзвінск",
			"Круглы",
			"Слуцкая",
			"Ветка",
			"Крупкі",
			"Смалявічы",
			"Вілейка",
			"Смаргонь",
			"Віцебск",
			"Лепель",
			"Салігорск",
			"Ваўкавыск",
			"Ліда",
			"Стары",
			"Дарожныя магістралі",
			"Валожын",
			"Лагойск",
			"Калонка",
			"Лунінец",
			"Столін",
			"Ганцавічы",
			"Ляхавічы",
			"Талачын",
			"Глыбокі",
			"Тураўскі",
			"Гомель",
			"Маларыта",
			"Горкі",
			"Узда",
			"Мікашэвічы",
			"Гродна",
			"Мінск",
			"Фаніпаль",
			"Міёры",
			"Давыд-Гарадок",
			"Магілёў",
			"Хойнікі",
			"Дзяржынск",
			"Мазыр"
		};

        public string[] Streets => new string[] 
		{
			"вул.Савецкая",
			"вул.Маладзёжная",
			"вул.Цэнтральная",
			"вул.Школьная",
			"вул.Новя",
			"вул.Садовая",
			"вул.Лясная",
			"вул.Набярэжная",
			"вул.Леніна",
			"вул.Света",
			"вул.Кастрычніцкая",
			"вул.Зялёная",
			"вул.Камсамольская",
			"вул.Зарэчная",
			"вул.Першамайская",
			"вул.Гагарыная",
			"вул.Палявая",
			"вул.Лугавя",
			"вул.Піянерская",
			"вул.Кіра",
			"вул.Юбілейная",
			"вул.Паўночная",
			"вул.Пралетарская",
			"вул.Стэпавая",
			"вул.Пушкіная",
			"вул.Калініная",
			"вул.Паўднёвая",
			"вул.Калгасная",
			"вул.Рабочая",
			"вул.Сонечная",
			"вул.Чыгуначная",
			"вул.Усходная",
			"вул.Заводская",
			"вул.Чапаевая",
			"вул.Нагорная",
			"вул.Будаўніка",
			"вул.Берагавая",
			"вул.Перамогш",
			"вул.Гаротная",
			"вул.Кааператыўная",
			"вул.Чырвонаармейская",
			"вул.Саўгасная",
			"вул.Рачная",
			"вул.Школьная",
			"вул.Спартыўны",
			"вул.Азёрная",
			"вул.Будаўнічая",
			"вул.Паркавая",
			"вул.Чкалава",
			"вул.Мічурына",
			"вул.Падгорны",
			"вул.Дружбы",
			"вул.Паштовая",
			"вул.Партызанская",
			"вул.Вакзальная",
			"вул.Лермантава",
			"вул.Свабоды",
			"вул.Дарожная",
			"вул.Дачная",
			"вул.Маякоўскага",
			"вул.Заходняя",
			"вул.Фрунзе",
			"вул.Дзяржынская",
			"вул.Маскоўская",
			"вул.Свярдлова",
			"вул.Някрасава",
			"вул.Гогаля",
			"вул.Чырвоная",
			"вул.Працоўная",
			"вул.Шашэйна",
			"вул.Чэхава",
			"вул.Камуністычная"
		};

		public string ZipCode => random.Next(100000, 999999).ToString();

		public string NumberHome => "д." + random.Next(1, 300).ToString();

		public string NumberFlat => "кв." + random.Next(1, 300).ToString();

		public string Phone => "+375(29)" + random.Next(1000000, 9999999).ToString("###-##-##");

	}
}
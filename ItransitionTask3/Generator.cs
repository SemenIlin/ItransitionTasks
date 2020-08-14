using ItransitionTask3.Initialses;
using ItransitionTask3.Address;

namespace ItransitionTask3
{
    public class Generator : Randomizer
    {
        private readonly Errors.Errors _errors;

        public Generator(Errors.Errors errors)
        {
            _errors = errors;
        }

        public Person GetGeneratePerson(string locale, bool gender = true)
        {
            IInitials initials = null;
            IAddress address = null;

            switch (locale)
            {
                case "ru_RU":
                case "ru":
                    initials = new InitialsRu();
                    address = new AddressRu();
                    break;
                case "be_BY":
                case "be":
                    initials = new InitialsBe();
                    address = new AddressBe();
                    break;
                case "en_Us":
                case "en":
                    initials = new InitialsEn();
                    address = new AddressEn();
                    break;
                default:
                    throw new System.ArgumentException("Unknow location");
            }

            return Generate(initials, address, gender, random);
        }

        private Person Generate(IInitials initials, IAddress address, bool gender, System.Random random)
        {
            string country = _errors.GenerateError(address.Country);
            string city = _errors.GenerateError(address.Cities[random.Next(0, address.Cities.Length)]);
            string street = _errors.GenerateError(address.Streets[random.Next(0, address.Streets.Length)]);
            string numberHome = _errors.GenerateError(address.NumberHome);
            string flat = _errors.GenerateError(address.NumberFlat);
            string phone = _errors.GenerateError(address.Phone);
            string zipCode = _errors.GenerateError(address.ZipCode);

            string manPatronymic = initials.ManPatronymics[random.Next(0, initials.ManPatronymics.Length)];
            string manFirstName = initials.ManFirstName[random.Next(0, initials.ManFirstName.Length)];
            string manLastName = initials.ManLastName[random.Next(0, initials.ManLastName.Length)];

            string womanPatronymic = initials.WomanPatronymics[random.Next(0, initials.WomanPatronymics.Length)];
            string womanFirstName = initials.WomanFirstName[random.Next(0, initials.WomanFirstName.Length)];
            string womanLastName = initials.WomanLastName[random.Next(0, initials.WomanLastName.Length)];

            return gender ? new Person()
            {
                FirstName = _errors.GenerateError(manFirstName),
                LastName = _errors.GenerateError(manLastName),
                Patronymic = _errors.GenerateError(manPatronymic),
                Country = country,
                City = city,
                Street = street,
                NumberHome = numberHome,
                NumberFlat = flat,
                ZipCode = zipCode,
                Phone = phone
            } :
                            new Person()
                            {
                                FirstName = _errors.GenerateError(womanFirstName),
                                LastName = _errors.GenerateError(womanLastName),
                                Patronymic = _errors.GenerateError(womanPatronymic),
                                Country = country,
                                City = city,
                                Street = street,
                                NumberHome = numberHome,
                                NumberFlat = flat,
                                ZipCode = zipCode,
                                Phone = phone
                            };
        }
    }
}

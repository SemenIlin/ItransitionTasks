namespace ItransitionTask3.Address
{
    public class AddressEn : Randomizer, IAddress
    {
        public string Country => "USA";

        public string[] Cities => new string[]
        {
            "New York",
            "Los Angeles",
            "Chicago",
            "Houston",
            "Louisville",
            "Baltimore",
            "Milwaukee",
            "Albuquerque",
            "Phoenix",
            "Philadelphia",
            "San Antonio",
            "San Diego",
            "Dallas",
            "San Jose",
            "Austin",
            "Jacksonville",
            "Fort Worth",
            "Columbus",
            "Charlotte",
            "San Francisco",
            "Indianapolis",
            "Seattle",
            "Denver",
            "Washington",
            "Boston",
            "Nashville",
            "Detroit",
            "Oklahoma City",
            "Portland",
            "Las Vegas",
            "Memphis"
        };

        public string[] Streets => new string[]
        {
            "Dickson Street",
            "State Line Avenue",
            "Airport Boulevard",
            "Government Street",
            "Old Shell Road",
            "Bell Road",
            "Lake Mary Road",
            "Stravenue",
            "Van Buren Street",
            "Charter Oak Place",
            "Hillhouse Avenue",
            "Ashby Avenue",
            "Piedmont Avenue",
            "San Pablo Avenu",
            "Shattuck Avenue",
            "Solano Avenue",
            "Telegraph Avenue",
            "International Boulevard",
            "Cherry Camp Road",
            "Passaic Street",
            "Norma Avenue",
            "Beechwood Avenue",
            "Masonic Hill Road",
            "Hide A Way Road",
            "Thorn Street",
            "Cabell Avenue",
            "Vine Street",
            "Green Gate Lane",
            "Petunia Way",
            "Blackwell Street",
            "Kimberly Way",
            "Tetrick Road"
        };

        public string ZipCode => random.Next(10000, 99999).ToString();

        public string NumberHome => "№" + random.Next(1, 300).ToString();

        public string NumberFlat => "#" + random.Next(1, 300).ToString();

        public string Phone => random.Next(10000000, 99999999).ToString("###-###-##") + "26";
    }
}

namespace ItransitionTask3.Errors
{
    public class ChangeSymbolError :Randomizer, IError
    {
        public string Error(string word)
        {
            if (word.Length == 1)
            {
                return word;
            }
            int randomValue = random.Next(0, word.Length - 1);

            char[] symbolsArray = word.ToCharArray();
            char temperary = symbolsArray[0];
            symbolsArray[0] = symbolsArray[randomValue];
            symbolsArray[randomValue] = temperary;

            return new string(symbolsArray);
        }
    }
}
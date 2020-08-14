namespace ItransitionTask3.Errors
{
    public class ReplaceSymbolError : Randomizer,IError
    {
        private char[] symbols = new char[7]
        {
            '!','@','$','%','^','&','*'
        };

        public string Error(string word)
        {
            int randomValue = random.Next(0, word.Length - 1);
            int randomSymbol = random.Next(0, symbols.Length - 1);
            word = string.Format("{0}{1}", symbols[randomSymbol], word.Remove(randomValue, 1));
            
            return word;
        }
    }
}
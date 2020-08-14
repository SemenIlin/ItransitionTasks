namespace ItransitionTask3.Errors
{
    public class UpperSymbolError : Randomizer, IError
    {
        public string Error(string word)
        {
            int randomValue = random.Next(0, word.Length - 1);
            if(System.Char.IsLetter(word[randomValue]))
            {
                word = string.Format("{0}{1}", char.ToUpper(word[randomValue]), word.Remove(randomValue, 1));
            }

            return word;
        }
    }
}
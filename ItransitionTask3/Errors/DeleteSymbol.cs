namespace ItransitionTask3.Errors
{
    public class DeleteSymbol : Randomizer, IError
    {        
        public string Error(string word)
        {
            if(word.Length == 1)
            {
                return word;
            }

            int deletedSymbol = random.Next(0, word.Length - 1);
            string result = "";
            for(int i = 0; i < word.Length; i++)
            {
                if(i == deletedSymbol)
                {
                    continue;
                }

                result += word[i];
            }

            return result;
        }
    }
}
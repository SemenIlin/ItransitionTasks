namespace ItransitionTask3.Errors
{
    public class GenderPatronymic : IError
    {
        public string Error(string word)
        {
            if(word.Length <= 3)
            {
                return word;
            }
            string result = "";
            int length = word.Length;
            string wordPatronymic = word.Substring(length - 2, 2); 

            string manPatronymic = "ич";
            string womanPatronymic = "на";
            if(wordPatronymic == manPatronymic)
            {
                return ChangePatronymic(result, word, womanPatronymic, length);
            }
            else
            {
                return ChangePatronymic(result, word, manPatronymic, length);
            }
            
        }

        private string ChangePatronymic(string result, string word, string ending, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (i == length - 2)
                {
                    break;
                }

                result += word[i];
            }

            return result += ending;
        }
    }
}
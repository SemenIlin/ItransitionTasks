namespace ItransitionTask3.Errors
{
    public class AddSymbol : Randomizer,IError 
    {
        private char[] symbols = new char[44]
        {
            'q','w','e','r','t','y','u','i','o','p','a','s','d','f','g','h','j','k','l','z','x','c','v','b','n','m',
            '1','2','3','4','5','6','7','8','9','0',
            '!','$','%','^','&','*','(',')'
        };
        public string Error(string word)
        {
            return word + symbols[random.Next(0, 44)];
        }
    }
}
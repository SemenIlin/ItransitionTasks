using System.Collections.Generic;

namespace ItransitionTask3.Errors
{
    public class Errors : Randomizer
    {
        private double _quantityErrors = 0;        
        private double _count;

        public Errors(double count)
        {
            _count = count;
        }

        private List<IError> tempErrors = new List<IError>();              

        public string GenerateError(string word)
        {
            if (_count == 0.0)
            {
                return word;
            }

            int countErors = (int)_count;

            _quantityErrors += _count - countErors;
            string result = word;
            for (int i = 0; i < countErors || _quantityErrors >= 1; i++)
            {
                if (tempErrors.Count == 0)
                {
                    foreach (var item in TypeErrors)
                    {
                        tempErrors.Add(item);
                    }
                }

                int typeError = random.Next(0, tempErrors.Count);
                result = tempErrors[typeError].Error(result);
                tempErrors.RemoveAt(typeError);

                if(_quantityErrors >= 1)
                {
                    i++;
                    _quantityErrors--;
                }
            }
            return result;
        }

        public List<IError> TypeErrors => new List<IError>()
        {
            new ChangeSymbolError(),
            new DeleteSymbol(),
            new GenderPatronymic(),
            new AddSymbol(),
            new UpperSymbolError(),
            new ReplaceSymbolError()
        };

        public void AddError(IError error)
        {
            TypeErrors.Add(error);
        }        
    }
}
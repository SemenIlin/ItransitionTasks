namespace ItransitionTask3.Address
{
    public interface IAddress
    {
        public string Country { get;}
        public string[] Cities { get;}
        public string[] Streets { get; }
        public string ZipCode { get; }
        public string NumberHome { get; }
        public string NumberFlat { get; }
        public string Phone { get; }
    }
}

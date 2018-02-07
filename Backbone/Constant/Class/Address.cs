using BackBone.Constants.Enumerations;

namespace BackBone.Constants.Classes
{
    public class Address
    {
        public int Identifier { get; set; }

        public string Street1 { get; set; }

        public string Street2 { get; set; }

        public string City { get; set; }

        public State State { get; set; }

        public int Zip { get; set; }

        public Address(int id, string street1, string street2, string city, State state, int zip)
        {
            Identifier = id;
            Street1 = street1;
            Street2 = street2;
            City = city;
            State = state;
            Zip = zip;
        }
    }
}

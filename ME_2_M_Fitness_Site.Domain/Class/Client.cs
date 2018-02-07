using BackBone.Constants.Classes;

namespace ME_2_M_Fitness_Site.Domain.Class
{
    public class Client
    {
        public int Identifier { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Address Address { get; set; }
    }
}

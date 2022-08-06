
namespace DockerAPI.Models
{
    public class Customer
    {

        public Guid CustomerId{get; set;}
        public DateTime CreationDate{get; set;}
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public string Email{get; set;}
        public string MobileNumber{get; set;}

        public string Remarks{get; set;}
    }

}
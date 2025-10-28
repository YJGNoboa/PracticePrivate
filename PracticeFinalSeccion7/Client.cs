//Class client

namespace PracticeFinalSeccion7
{
    class Client
    {
        public string Name {  get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string RFC { get; set; }


        public Client(string namePa, string lastNamePa, string addressPa, string rfcPa)
        {
            Name = namePa;
            LastName = lastNamePa;
            Address = addressPa;
            RFC = rfcPa;
        }
        public override string ToString()
        {
            string message;

            message = "Name: " + Name + " " + LastName + "\naddreess: " + Address + "\nRFC " + RFC;
            return message;
        }
    }
}

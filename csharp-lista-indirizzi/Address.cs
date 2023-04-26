// See https://aka.ms/new-console-template for more information

namespace csharpListaIndirizzi{
    public class Address
    {
       private string name;
       private string surname;
       private string street;
       private string city;
       private string province;
       private int ZIP;


       public Address(string name, string surname, string street, string city, string province, int ZIP)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;   
            this.ZIP = ZIP;
           
        }

       public string GetName ()
        {
            return name;
        }
        public string GetSurname() 
        { 
            return surname;
        }
        public string GetStreet()
        {
            return street;
        }
        public string GetCity()
        {
            return city;
        }
        public string GetProvince() 
        {
            return province;
        }
        public int GetZIP()
        {
            return ZIP;
        }


        public override string ToString()
        {
           
           string  strrappresentation = "Nome: " + "  " + this.name + ", ";
            strrappresentation += "cognome: " + "  " + this.surname + ", ";
            strrappresentation += "city: " + "   " + this.city + ", ";
            strrappresentation += "via: " + "  " + this.street + ", ";
            strrappresentation += "privincia: " + "  " + this.province + ", ";
            strrappresentation += "zip: " + "  " + this.ZIP + ", ";
            strrappresentation += "-----------------------------------";

            return strrappresentation;



        }
    }

}
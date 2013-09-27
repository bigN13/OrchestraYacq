using OrchestraYacq.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace OrchestraYacq.Models
{
    public class Person : BaseClass
    {
        private int personId;
        public int PersonId
        {
            get { return personId; }
            set { personId = value; OnPropertyChanged("PersonId"); }
        }

        private string firstName;
        [DisplayName("FirstName")]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; OnPropertyChanged("FirstName"); }
        }

        private string lastName;
        [DisplayName("LastName")]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged("LastName"); }
        }

        private DateTime dateOfBirth;

        [DisplayName("DateOfBirth")]
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; OnPropertyChanged("DateOfBirth"); }
        }

        private int age;

        [DisplayName("Age")]
        public int Age
        {
            get { return age; }
            set { age = value; OnPropertyChanged("Age"); }
        }

        private string sex;

        [DisplayName("Sex")]
        public string Sex
        {
            get { return sex; }
            set { sex = value; OnPropertyChanged("Sex"); }
        }

        private string phoneNumber;
        [DisplayName("PhoneNumber")]
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; OnPropertyChanged("PhoneNumber"); }
        }
    }

    public static class SampleData 
    {
        public static ObservableCollection<Person> Persons { get; set; }

        public static void Seed()
        {
            Persons = new ObservableCollection<Person>();
            Persons.Add(new Person { PersonId = 1, FirstName = "Donald", LastName = "Blakely", DateOfBirth = DateTime.Parse("8/22/1935", System.Globalization.CultureInfo.InvariantCulture), Age = 78, Sex = "male", PhoneNumber = "(07) 4087 1980" });
            Persons.Add(new Person { PersonId = 2, FirstName = "Mary", LastName = "Downing", DateOfBirth = DateTime.Parse("2/20/1976", System.Globalization.CultureInfo.InvariantCulture), Age = 37, Sex = "female", PhoneNumber = "(03) 5300 2356" });
            Persons.Add(new Person { PersonId = 3, FirstName = "Jennette", LastName = "Hanson", DateOfBirth = DateTime.Parse("4/25/1937", System.Globalization.CultureInfo.InvariantCulture), Age = 76, Sex = "female", PhoneNumber = "(03) 5303 1337" });
            Persons.Add(new Person { PersonId = 4, FirstName = "Joseph", LastName = "Morgan", DateOfBirth = DateTime.Parse("5/10/1961", System.Globalization.CultureInfo.InvariantCulture), Age = 52, Sex = "male", PhoneNumber = "(03) 5307 2844" });
            Persons.Add(new Person { PersonId = 5, FirstName = "Willie", LastName = "Taylor", DateOfBirth = DateTime.Parse("5/29/1969", System.Globalization.CultureInfo.InvariantCulture), Age = 44, Sex = "male", PhoneNumber = "(02) 4070 7961" });
            Persons.Add(new Person { PersonId = 6, FirstName = "John", LastName = "Wallace", DateOfBirth = DateTime.Parse("12/12/1975", System.Globalization.CultureInfo.InvariantCulture), Age = 38, Sex = "male", PhoneNumber = "(07) 4596 3245" });
            Persons.Add(new Person { PersonId = 7, FirstName = "Dean", LastName = "Page", DateOfBirth = DateTime.Parse("6/23/1932", System.Globalization.CultureInfo.InvariantCulture), Age = 81, Sex = "male", PhoneNumber = "(02) 6182 4863" });
            Persons.Add(new Person { PersonId = 8, FirstName = "Audra", LastName = "Obrien", DateOfBirth = DateTime.Parse("9/23/1966", System.Globalization.CultureInfo.InvariantCulture), Age = 47, Sex = "female", PhoneNumber = "(07) 3040 2508" });
            Persons.Add(new Person { PersonId = 9, FirstName = "Aline", LastName = "Blair", DateOfBirth = DateTime.Parse("10/22/1952", System.Globalization.CultureInfo.InvariantCulture), Age = 61, Sex = "female", PhoneNumber = "(02) 4913 9965" });
            Persons.Add(new Person { PersonId = 10, FirstName = "Dana", LastName = "Ricks", DateOfBirth = DateTime.Parse("12/10/1971", System.Globalization.CultureInfo.InvariantCulture), Age = 42, Sex = "female", PhoneNumber = "(03) 6257 9159" });
            Persons.Add(new Person { PersonId = 11, FirstName = "Paul", LastName = "Villalon", DateOfBirth = DateTime.Parse("5/24/1962", System.Globalization.CultureInfo.InvariantCulture), Age = 51, Sex = "male", PhoneNumber = "(08) 9024 5969" });
            Persons.Add(new Person { PersonId = 12, FirstName = "Steven", LastName = "Thorpe", DateOfBirth = DateTime.Parse("2/11/1979", System.Globalization.CultureInfo.InvariantCulture), Age = 34, Sex = "male", PhoneNumber = "(03) 5376 0997" });
            Persons.Add(new Person { PersonId = 13, FirstName = "Vernon", LastName = "Pavon", DateOfBirth = DateTime.Parse("10/22/1929", System.Globalization.CultureInfo.InvariantCulture), Age = 84, Sex = "male", PhoneNumber = "(02) 4047 0075" });
            Persons.Add(new Person { PersonId = 14, FirstName = "Marilyn", LastName = "Gonzales", DateOfBirth = DateTime.Parse("11/28/1933", System.Globalization.CultureInfo.InvariantCulture), Age = 80, Sex = "female", PhoneNumber = "(03) 6297 4227" });
            Persons.Add(new Person { PersonId = 15, FirstName = "Amy", LastName = "Decaro", DateOfBirth = DateTime.Parse("9/23/1949", System.Globalization.CultureInfo.InvariantCulture), Age = 64, Sex = "female", PhoneNumber = "(02) 9365 3409" });
            Persons.Add(new Person { PersonId = 16, FirstName = "Margie", LastName = "Miller", DateOfBirth = DateTime.Parse("9/23/1938", System.Globalization.CultureInfo.InvariantCulture), Age = 75, Sex = "female", PhoneNumber = "(07) 4560 2433" });
            Persons.Add(new Person { PersonId = 17, FirstName = "Vanessa", LastName = "Higgins", DateOfBirth = DateTime.Parse("9/26/1963", System.Globalization.CultureInfo.InvariantCulture), Age = 50, Sex = "female", PhoneNumber = "(03) 9976 6789" });
            Persons.Add(new Person { PersonId = 18, FirstName = "Yetta", LastName = "Howard", DateOfBirth = DateTime.Parse("10/10/1976", System.Globalization.CultureInfo.InvariantCulture), Age = 37, Sex = "female", PhoneNumber = "(08) 9415 3661" });
            Persons.Add(new Person { PersonId = 19, FirstName = "Wyatt", LastName = "Moss", DateOfBirth = DateTime.Parse("7/18/1959", System.Globalization.CultureInfo.InvariantCulture), Age = 54, Sex = "male", PhoneNumber = "(03) 5363 8402" });
            Persons.Add(new Person { PersonId = 20, FirstName = "David", LastName = "Garcia", DateOfBirth = DateTime.Parse("10/18/1955", System.Globalization.CultureInfo.InvariantCulture), Age = 58, Sex = "male", PhoneNumber = "(03) 5358 7578" });
            Persons.Add(new Person { PersonId = 21, FirstName = "James", LastName = "Curtis", DateOfBirth = DateTime.Parse("7/30/1988", System.Globalization.CultureInfo.InvariantCulture), Age = 25, Sex = "male", PhoneNumber = "(07) 4585 3499" });
            Persons.Add(new Person { PersonId = 22, FirstName = "John", LastName = "Shepard", DateOfBirth = DateTime.Parse("4/4/1942", System.Globalization.CultureInfo.InvariantCulture), Age = 71, Sex = "male", PhoneNumber = "(08) 8730 3693" });
            Persons.Add(new Person { PersonId = 23, FirstName = "Mallory", LastName = "Morrison", DateOfBirth = DateTime.Parse("5/23/1946", System.Globalization.CultureInfo.InvariantCulture), Age = 67, Sex = "female", PhoneNumber = "(02) 4707 9496" });
            Persons.Add(new Person { PersonId = 24, FirstName = "Hanna", LastName = "Bullock", DateOfBirth = DateTime.Parse("9/26/1976", System.Globalization.CultureInfo.InvariantCulture), Age = 37, Sex = "female", PhoneNumber = "(02) 4011 8171" });
            Persons.Add(new Person { PersonId = 25, FirstName = "John", LastName = "Pratt", DateOfBirth = DateTime.Parse("1/28/1934", System.Globalization.CultureInfo.InvariantCulture), Age = 79, Sex = "male", PhoneNumber = "(08) 9479 7086" });
            Persons.Add(new Person { PersonId = 26, FirstName = "Freddie", LastName = "Rogge", DateOfBirth = DateTime.Parse("2/27/1931", System.Globalization.CultureInfo.InvariantCulture), Age = 82, Sex = "female", PhoneNumber = "(07) 4046 8355" });
            Persons.Add(new Person { PersonId = 27, FirstName = "Betty", LastName = "Moses", DateOfBirth = DateTime.Parse("4/8/1975", System.Globalization.CultureInfo.InvariantCulture), Age = 38, Sex = "female", PhoneNumber = "(02) 6172 5097" });
            Persons.Add(new Person { PersonId = 28, FirstName = "Douglas", LastName = "Dickens", DateOfBirth = DateTime.Parse("3/30/1959", System.Globalization.CultureInfo.InvariantCulture), Age = 54, Sex = "male", PhoneNumber = "(07) 4526 5439" });
            Persons.Add(new Person { PersonId = 29, FirstName = "Elinor", LastName = "Johnson", DateOfBirth = DateTime.Parse("10/2/1950", System.Globalization.CultureInfo.InvariantCulture), Age = 63, Sex = "female", PhoneNumber = "(08) 9058 6307" });
            Persons.Add(new Person { PersonId = 30, FirstName = "Paul", LastName = "Wade", DateOfBirth = DateTime.Parse("8/12/1955", System.Globalization.CultureInfo.InvariantCulture), Age = 58, Sex = "male", PhoneNumber = "(03) 5350 3047" });
            Persons.Add(new Person { PersonId = 31, FirstName = "Michele", LastName = "Byrd", DateOfBirth = DateTime.Parse("10/29/1993", System.Globalization.CultureInfo.InvariantCulture), Age = 20, Sex = "female", PhoneNumber = "(08) 8250 9348" });
            Persons.Add(new Person { PersonId = 32, FirstName = "Dale", LastName = "Mendez", DateOfBirth = DateTime.Parse("3/2/1932", System.Globalization.CultureInfo.InvariantCulture), Age = 81, Sex = "male", PhoneNumber = "(07) 4046 9028" });
            Persons.Add(new Person { PersonId = 33, FirstName = "Anthony", LastName = "Ferrer", DateOfBirth = DateTime.Parse("8/15/1945", System.Globalization.CultureInfo.InvariantCulture), Age = 68, Sex = "male", PhoneNumber = "(07) 4519 1790" });
            Persons.Add(new Person { PersonId = 34, FirstName = "William", LastName = "Glass", DateOfBirth = DateTime.Parse("6/17/1982", System.Globalization.CultureInfo.InvariantCulture), Age = 31, Sex = "male", PhoneNumber = "(02) 9814 6796" });
            Persons.Add(new Person { PersonId = 35, FirstName = "William", LastName = "Burke", DateOfBirth = DateTime.Parse("12/24/1951", System.Globalization.CultureInfo.InvariantCulture), Age = 62, Sex = "male", PhoneNumber = "(02) 4606 0088" });
            Persons.Add(new Person { PersonId = 36, FirstName = "Billie", LastName = "Turner", DateOfBirth = DateTime.Parse("1/21/1990", System.Globalization.CultureInfo.InvariantCulture), Age = 23, Sex = "female", PhoneNumber = "(07) 5686 0649" });
            Persons.Add(new Person { PersonId = 37, FirstName = "Kyle", LastName = "Wilson", DateOfBirth = DateTime.Parse("7/1/1967", System.Globalization.CultureInfo.InvariantCulture), Age = 46, Sex = "male", PhoneNumber = "(02) 4620 7166" });
            Persons.Add(new Person { PersonId = 38, FirstName = "Mary", LastName = "Leggett", DateOfBirth = DateTime.Parse("1/15/1934", System.Globalization.CultureInfo.InvariantCulture), Age = 79, Sex = "female", PhoneNumber = "(03) 9052 3444" });
            Persons.Add(new Person { PersonId = 39, FirstName = "Steve", LastName = "Scharff", DateOfBirth = DateTime.Parse("12/24/1935", System.Globalization.CultureInfo.InvariantCulture), Age = 78, Sex = "male", PhoneNumber = "(02) 6725 6632" });
            Persons.Add(new Person { PersonId = 40, FirstName = "Henry", LastName = "McCormack", DateOfBirth = DateTime.Parse("9/5/1987", System.Globalization.CultureInfo.InvariantCulture), Age = 26, Sex = "male", PhoneNumber = "(03) 5340 1107" });
            Persons.Add(new Person { PersonId = 41, FirstName = "Cynthia", LastName = "Johnson", DateOfBirth = DateTime.Parse("12/2/1969", System.Globalization.CultureInfo.InvariantCulture), Age = 44, Sex = "female", PhoneNumber = "(02) 6743 7137" });
            Persons.Add(new Person { PersonId = 42, FirstName = "Shirely", LastName = "Spencer", DateOfBirth = DateTime.Parse("9/17/1938", System.Globalization.CultureInfo.InvariantCulture), Age = 75, Sex = "female", PhoneNumber = "(02) 4972 6365" });
            Persons.Add(new Person { PersonId = 43, FirstName = "Ethel", LastName = "Doe", DateOfBirth = DateTime.Parse("1/20/1968", System.Globalization.CultureInfo.InvariantCulture), Age = 45, Sex = "female", PhoneNumber = "(08) 8771 3112" });
            Persons.Add(new Person { PersonId = 44, FirstName = "Robert", LastName = "Preston", DateOfBirth = DateTime.Parse("1/1/1990", System.Globalization.CultureInfo.InvariantCulture), Age = 23, Sex = "male", PhoneNumber = "(02) 4011 9822" });
            Persons.Add(new Person { PersonId = 45, FirstName = "Daniel", LastName = "Mitchell", DateOfBirth = DateTime.Parse("8/3/1992", System.Globalization.CultureInfo.InvariantCulture), Age = 21, Sex = "male", PhoneNumber = "(02) 4942 5126" });
            Persons.Add(new Person { PersonId = 46, FirstName = "Jimmie", LastName = "Burrell", DateOfBirth = DateTime.Parse("11/2/1928", System.Globalization.CultureInfo.InvariantCulture), Age = 85, Sex = "female", PhoneNumber = "(08) 8702 4788" });
            Persons.Add(new Person { PersonId = 47, FirstName = "Michael", LastName = "Cook", DateOfBirth = DateTime.Parse("1/25/1967", System.Globalization.CultureInfo.InvariantCulture), Age = 46, Sex = "male", PhoneNumber = "(08) 9433 1419" });
            Persons.Add(new Person { PersonId = 48, FirstName = "Amparo", LastName = "Byrnes", DateOfBirth = DateTime.Parse("2/9/1972", System.Globalization.CultureInfo.InvariantCulture), Age = 41, Sex = "female", PhoneNumber = "(02) 4910 5065" });
            Persons.Add(new Person { PersonId = 49, FirstName = "Patricia", LastName = "Matthews", DateOfBirth = DateTime.Parse("1/21/1974", System.Globalization.CultureInfo.InvariantCulture), Age = 39, Sex = "female", PhoneNumber = "(02) 6118 5871" });
            Persons.Add(new Person { PersonId = 50, FirstName = "Catherine", LastName = "Stockwell", DateOfBirth = DateTime.Parse("4/3/1941", System.Globalization.CultureInfo.InvariantCulture), Age = 72, Sex = "female", PhoneNumber = "(02) 4940 9986" });
            Persons.Add(new Person { PersonId = 51, FirstName = "David", LastName = "Stump", DateOfBirth = DateTime.Parse("1/11/1975", System.Globalization.CultureInfo.InvariantCulture), Age = 38, Sex = "male", PhoneNumber = "(02) 4072 5836" });
            Persons.Add(new Person { PersonId = 52, FirstName = "Lori", LastName = "Williams", DateOfBirth = DateTime.Parse("12/4/1988", System.Globalization.CultureInfo.InvariantCulture), Age = 25, Sex = "female", PhoneNumber = "(02) 6773 0502" });
            Persons.Add(new Person { PersonId = 53, FirstName = "Randy", LastName = "Wilde", DateOfBirth = DateTime.Parse("7/2/1942", System.Globalization.CultureInfo.InvariantCulture), Age = 71, Sex = "male", PhoneNumber = "(07) 4948 2821" });
            Persons.Add(new Person { PersonId = 54, FirstName = "Irene", LastName = "Moore", DateOfBirth = DateTime.Parse("9/8/1937", System.Globalization.CultureInfo.InvariantCulture), Age = 76, Sex = "female", PhoneNumber = "(08) 8702 5346" });
            Persons.Add(new Person { PersonId = 55, FirstName = "Kristine", LastName = "Card", DateOfBirth = DateTime.Parse("6/3/1940", System.Globalization.CultureInfo.InvariantCulture), Age = 73, Sex = "female", PhoneNumber = "(02) 4032 9210" });
            Persons.Add(new Person { PersonId = 56, FirstName = "Paul", LastName = "Lambert", DateOfBirth = DateTime.Parse("8/28/1984", System.Globalization.CultureInfo.InvariantCulture), Age = 29, Sex = "male", PhoneNumber = "(03) 6280 0921" });
            Persons.Add(new Person { PersonId = 57, FirstName = "Abel", LastName = "Hardin", DateOfBirth = DateTime.Parse("5/21/1968", System.Globalization.CultureInfo.InvariantCulture), Age = 45, Sex = "male", PhoneNumber = "(02) 4096 8727" });
            Persons.Add(new Person { PersonId = 58, FirstName = "William", LastName = "Mueller", DateOfBirth = DateTime.Parse("12/22/1948", System.Globalization.CultureInfo.InvariantCulture), Age = 65, Sex = "male", PhoneNumber = "(07) 4971 6591" });
            Persons.Add(new Person { PersonId = 59, FirstName = "Vicky", LastName = "Conley", DateOfBirth = DateTime.Parse("12/18/1971", System.Globalization.CultureInfo.InvariantCulture), Age = 42, Sex = "female", PhoneNumber = "(08) 8298 1720" });
            Persons.Add(new Person { PersonId = 60, FirstName = "Jay", LastName = "Schmitt", DateOfBirth = DateTime.Parse("7/10/1976", System.Globalization.CultureInfo.InvariantCulture), Age = 37, Sex = "male", PhoneNumber = "(07) 4592 8537" });
            Persons.Add(new Person { PersonId = 61, FirstName = "Erma", LastName = "Hurley", DateOfBirth = DateTime.Parse("12/31/1990", System.Globalization.CultureInfo.InvariantCulture), Age = 23, Sex = "female", PhoneNumber = "(03) 5347 3985" });
            Persons.Add(new Person { PersonId = 62, FirstName = "Mario", LastName = "Stein", DateOfBirth = DateTime.Parse("12/1/1986", System.Globalization.CultureInfo.InvariantCulture), Age = 27, Sex = "male", PhoneNumber = "(07) 4951 0955" });
            Persons.Add(new Person { PersonId = 63, FirstName = "Clarence", LastName = "Arvizu", DateOfBirth = DateTime.Parse("3/17/1968", System.Globalization.CultureInfo.InvariantCulture), Age = 45, Sex = "male", PhoneNumber = "(03) 5301 8351" });
            Persons.Add(new Person { PersonId = 64, FirstName = "Ralph", LastName = "Vaughan", DateOfBirth = DateTime.Parse("11/10/1956", System.Globalization.CultureInfo.InvariantCulture), Age = 57, Sex = "male", PhoneNumber = "(07) 4573 8847" });
            Persons.Add(new Person { PersonId = 65, FirstName = "Miriam", LastName = "Paul", DateOfBirth = DateTime.Parse("5/19/1975", System.Globalization.CultureInfo.InvariantCulture), Age = 38, Sex = "female", PhoneNumber = "(03) 5373 1640" });
            Persons.Add(new Person { PersonId = 66, FirstName = "Joanna", LastName = "Isaacs", DateOfBirth = DateTime.Parse("1/3/1994", System.Globalization.CultureInfo.InvariantCulture), Age = 19, Sex = "female", PhoneNumber = "(02) 4974 8089" });
            Persons.Add(new Person { PersonId = 67, FirstName = "Luther", LastName = "Sullivan", DateOfBirth = DateTime.Parse("12/10/1940", System.Globalization.CultureInfo.InvariantCulture), Age = 73, Sex = "male", PhoneNumber = "(07) 3090 7574" });
            Persons.Add(new Person { PersonId = 68, FirstName = "Joshua", LastName = "Kelly", DateOfBirth = DateTime.Parse("2/3/1930", System.Globalization.CultureInfo.InvariantCulture), Age = 83, Sex = "male", PhoneNumber = "(02) 4297 2747" });
            Persons.Add(new Person { PersonId = 69, FirstName = "Patricia", LastName = "Billings", DateOfBirth = DateTime.Parse("3/12/1993", System.Globalization.CultureInfo.InvariantCulture), Age = 20, Sex = "female", PhoneNumber = "(03) 5304 5649" });
            Persons.Add(new Person { PersonId = 70, FirstName = "Harry", LastName = "Allen", DateOfBirth = DateTime.Parse("1/26/1940", System.Globalization.CultureInfo.InvariantCulture), Age = 73, Sex = "male", PhoneNumber = "(07) 4065 6075" });
            Persons.Add(new Person { PersonId = 71, FirstName = "Katrina", LastName = "Kimberly", DateOfBirth = DateTime.Parse("1/27/1945", System.Globalization.CultureInfo.InvariantCulture), Age = 68, Sex = "female", PhoneNumber = "(07) 3836 6086" });
            Persons.Add(new Person { PersonId = 72, FirstName = "Glenda", LastName = "Humphrey", DateOfBirth = DateTime.Parse("10/20/1947", System.Globalization.CultureInfo.InvariantCulture), Age = 66, Sex = "female", PhoneNumber = "(07) 3809 3361" });
            Persons.Add(new Person { PersonId = 73, FirstName = "George", LastName = "Cummings", DateOfBirth = DateTime.Parse("7/9/1983", System.Globalization.CultureInfo.InvariantCulture), Age = 30, Sex = "male", PhoneNumber = "(08) 9422 9758" });
            Persons.Add(new Person { PersonId = 74, FirstName = "Melida", LastName = "Forbes", DateOfBirth = DateTime.Parse("5/17/1979", System.Globalization.CultureInfo.InvariantCulture), Age = 34, Sex = "female", PhoneNumber = "(03) 6223 4509" });
            Persons.Add(new Person { PersonId = 75, FirstName = "Alice", LastName = "Collins", DateOfBirth = DateTime.Parse("2/25/1985", System.Globalization.CultureInfo.InvariantCulture), Age = 28, Sex = "female", PhoneNumber = "(07) 4970 9992" });
            Persons.Add(new Person { PersonId = 76, FirstName = "Ann", LastName = "Lay", DateOfBirth = DateTime.Parse("3/25/1949", System.Globalization.CultureInfo.InvariantCulture), Age = 64, Sex = "female", PhoneNumber = "(03) 5370 6130" });
            Persons.Add(new Person { PersonId = 77, FirstName = "Cleo", LastName = "Le", DateOfBirth = DateTime.Parse("12/9/1942", System.Globalization.CultureInfo.InvariantCulture), Age = 71, Sex = "female", PhoneNumber = "(03) 5355 3342" });
            Persons.Add(new Person { PersonId = 78, FirstName = "Robert", LastName = "Lozano", DateOfBirth = DateTime.Parse("1/16/1951", System.Globalization.CultureInfo.InvariantCulture), Age = 62, Sex = "male", PhoneNumber = "(08) 8273 2889" });
            Persons.Add(new Person { PersonId = 79, FirstName = "Dorthy", LastName = "Meadow", DateOfBirth = DateTime.Parse("4/25/1941", System.Globalization.CultureInfo.InvariantCulture), Age = 72, Sex = "female", PhoneNumber = "(07) 4064 2311" });
            Persons.Add(new Person { PersonId = 80, FirstName = "Mark", LastName = "Montgomery", DateOfBirth = DateTime.Parse("4/14/1948", System.Globalization.CultureInfo.InvariantCulture), Age = 65, Sex = "male", PhoneNumber = "(08) 9016 0086" });
            Persons.Add(new Person { PersonId = 81, FirstName = "Donald", LastName = "Brown", DateOfBirth = DateTime.Parse("6/1/1977", System.Globalization.CultureInfo.InvariantCulture), Age = 36, Sex = "male", PhoneNumber = "(07) 4515 4170" });
            Persons.Add(new Person { PersonId = 82, FirstName = "Irene", LastName = "Wolf", DateOfBirth = DateTime.Parse("1/24/1931", System.Globalization.CultureInfo.InvariantCulture), Age = 82, Sex = "female", PhoneNumber = "(03) 5313 8442" });
            Persons.Add(new Person { PersonId = 83, FirstName = "Robert", LastName = "Caballero", DateOfBirth = DateTime.Parse("12/5/1956", System.Globalization.CultureInfo.InvariantCulture), Age = 57, Sex = "male", PhoneNumber = "(02) 6704 0234" });
            Persons.Add(new Person { PersonId = 84, FirstName = "Ray", LastName = "Jones", DateOfBirth = DateTime.Parse("3/23/1937", System.Globalization.CultureInfo.InvariantCulture), Age = 76, Sex = "male", PhoneNumber = "(02) 4606 7766" });
            Persons.Add(new Person { PersonId = 85, FirstName = "Israel", LastName = "Packer", DateOfBirth = DateTime.Parse("11/19/1983", System.Globalization.CultureInfo.InvariantCulture), Age = 30, Sex = "male", PhoneNumber = "(02) 4056 9106" });
            Persons.Add(new Person { PersonId = 86, FirstName = "Elijah", LastName = "Case", DateOfBirth = DateTime.Parse("8/27/1954", System.Globalization.CultureInfo.InvariantCulture), Age = 59, Sex = "male", PhoneNumber = "(03) 5395 8957" });
            Persons.Add(new Person { PersonId = 87, FirstName = "Cassandra", LastName = "Waits", DateOfBirth = DateTime.Parse("4/12/1950", System.Globalization.CultureInfo.InvariantCulture), Age = 63, Sex = "female", PhoneNumber = "(02) 9637 5599" });
            Persons.Add(new Person { PersonId = 88, FirstName = "William", LastName = "Torres", DateOfBirth = DateTime.Parse("8/20/1950", System.Globalization.CultureInfo.InvariantCulture), Age = 63, Sex = "male", PhoneNumber = "(07) 4098 1584" });
            Persons.Add(new Person { PersonId = 89, FirstName = "Martin", LastName = "Ward", DateOfBirth = DateTime.Parse("2/17/1987", System.Globalization.CultureInfo.InvariantCulture), Age = 26, Sex = "male", PhoneNumber = "(02) 4981 7994" });
            Persons.Add(new Person { PersonId = 90, FirstName = "David", LastName = "Heintzelman", DateOfBirth = DateTime.Parse("6/21/1939", System.Globalization.CultureInfo.InvariantCulture), Age = 74, Sex = "male", PhoneNumber = "(03) 5354 8746" });
            Persons.Add(new Person { PersonId = 91, FirstName = "Angelo", LastName = "Regan", DateOfBirth = DateTime.Parse("6/30/1994", System.Globalization.CultureInfo.InvariantCulture), Age = 19, Sex = "male", PhoneNumber = "(08) 9022 3506" });
            Persons.Add(new Person { PersonId = 92, FirstName = "Joel", LastName = "Frost", DateOfBirth = DateTime.Parse("4/1/1941", System.Globalization.CultureInfo.InvariantCulture), Age = 72, Sex = "male", PhoneNumber = "(02) 6761 5624" });
            Persons.Add(new Person { PersonId = 93, FirstName = "Kelly", LastName = "Dougherty", DateOfBirth = DateTime.Parse("10/23/1990", System.Globalization.CultureInfo.InvariantCulture), Age = 23, Sex = "female", PhoneNumber = "(02) 6126 3839" });
            Persons.Add(new Person { PersonId = 94, FirstName = "Jessica", LastName = "Frank", DateOfBirth = DateTime.Parse("1/2/1941", System.Globalization.CultureInfo.InvariantCulture), Age = 72, Sex = "female", PhoneNumber = "(07) 3831 8088" });
            Persons.Add(new Person { PersonId = 95, FirstName = "Esther", LastName = "Mares", DateOfBirth = DateTime.Parse("7/9/1973", System.Globalization.CultureInfo.InvariantCulture), Age = 40, Sex = "female", PhoneNumber = "(07) 4087 2857" });
            Persons.Add(new Person { PersonId = 96, FirstName = "Judith", LastName = "Stockton", DateOfBirth = DateTime.Parse("2/26/1971", System.Globalization.CultureInfo.InvariantCulture), Age = 42, Sex = "female", PhoneNumber = "(03) 5323 4891" });
            Persons.Add(new Person { PersonId = 97, FirstName = "Samuel", LastName = "Shelton", DateOfBirth = DateTime.Parse("1/10/1983", System.Globalization.CultureInfo.InvariantCulture), Age = 30, Sex = "male", PhoneNumber = "(08) 8251 4242" });
            Persons.Add(new Person { PersonId = 98, FirstName = "Ralph", LastName = "Sledge", DateOfBirth = DateTime.Parse("8/13/1948", System.Globalization.CultureInfo.InvariantCulture), Age = 65, Sex = "male", PhoneNumber = "(02) 6179 7114" });
            Persons.Add(new Person { PersonId = 99, FirstName = "Diana", LastName = "Irwin", DateOfBirth = DateTime.Parse("5/1/1945", System.Globalization.CultureInfo.InvariantCulture), Age = 68, Sex = "female", PhoneNumber = "(03) 5300 3783" });
            Persons.Add(new Person { PersonId = 100, FirstName = "Charles", LastName = "McDorman", DateOfBirth = DateTime.Parse("4/5/1970", System.Globalization.CultureInfo.InvariantCulture), Age = 43, Sex = "male", PhoneNumber = "(02) 4079 0387" });
            Persons.Add(new Person { PersonId = 101, FirstName = "Rebekah", LastName = "Boyce", DateOfBirth = DateTime.Parse("2/4/1962", System.Globalization.CultureInfo.InvariantCulture), Age = 51, Sex = "female", PhoneNumber = "(03) 6281 0380" });
            Persons.Add(new Person { PersonId = 102, FirstName = "Barbara", LastName = "Robinson", DateOfBirth = DateTime.Parse("5/19/1945", System.Globalization.CultureInfo.InvariantCulture), Age = 68, Sex = "female", PhoneNumber = "(02) 6181 7751" });
            Persons.Add(new Person { PersonId = 103, FirstName = "Carol", LastName = "White", DateOfBirth = DateTime.Parse("12/24/1959", System.Globalization.CultureInfo.InvariantCulture), Age = 54, Sex = "female", PhoneNumber = "(08) 8702 7320" });
            Persons.Add(new Person { PersonId = 104, FirstName = "John", LastName = "Hostetler", DateOfBirth = DateTime.Parse("9/18/1947", System.Globalization.CultureInfo.InvariantCulture), Age = 66, Sex = "male", PhoneNumber = "(03) 9094 3069" });
            Persons.Add(new Person { PersonId = 105, FirstName = "Dennis", LastName = "Small", DateOfBirth = DateTime.Parse("10/23/1944", System.Globalization.CultureInfo.InvariantCulture), Age = 69, Sex = "male", PhoneNumber = "(03) 9610 6213" });









            //Persons.Add(new Person { PersonId = 1, FirstName = "Donald", LastName = "Blakely", DateOfBirth = DateTime.Parse("8/22/1935"), Age = 78, Sex = "male", PhoneNumber = "(07) 4087 1980" });
            //Persons = new ObservableCollection<Person>
            //{
            //    new Person { PersonId = 1, FirstName = "Donald", LastName ="Blakely", DateOfBirth =DateTime.Parse("8/22/1935"), Age =78, Sex = "male", PhoneNumber ="(07) 4087 1980" },
            //    new Person { PersonId = 2, FirstName = "Mary", LastName ="Downing", DateOfBirth =DateTime.Parse("2/20/1976"), Age =37, Sex = "female", PhoneNumber ="(03) 5300 2356" },
            //    new Person { PersonId = 3, FirstName = "Jennette", LastName ="Hanson", DateOfBirth =DateTime.Parse("4/25/1937"), Age =76, Sex = "female", PhoneNumber ="(03) 5303 1337" },
            //    new Person { PersonId = 4, FirstName = "Joseph", LastName ="Morgan", DateOfBirth =DateTime.Parse("5/10/1961"), Age =52, Sex = "male", PhoneNumber ="(03) 5307 2844" },
            //    new Person { PersonId = 5, FirstName = "Willie", LastName ="Taylor", DateOfBirth =DateTime.Parse("5/29/1969"), Age =44, Sex = "male", PhoneNumber ="(02) 4070 7961" },
            //    new Person { PersonId = 6, FirstName = "John", LastName ="Wallace", DateOfBirth =DateTime.Parse("12/12/1975"), Age =38, Sex = "male", PhoneNumber ="(07) 4596 3245" },
            //    new Person { PersonId = 7, FirstName = "Dean", LastName ="Page", DateOfBirth =DateTime.Parse("6/23/1932"), Age =81, Sex = "male", PhoneNumber ="(02) 6182 4863" },
            //    new Person { PersonId = 8, FirstName = "Audra", LastName ="Obrien", DateOfBirth =DateTime.Parse("9/23/1966"), Age =47, Sex = "female", PhoneNumber ="(07) 3040 2508" },
            //    new Person { PersonId = 9, FirstName = "Aline", LastName ="Blair", DateOfBirth =DateTime.Parse("10/22/1952"), Age =61, Sex = "female", PhoneNumber ="(02) 4913 9965" },
            //    new Person { PersonId = 10, FirstName = "Dana", LastName ="Ricks", DateOfBirth =DateTime.Parse("12/10/1971"), Age =42, Sex = "female", PhoneNumber ="(03) 6257 9159" },
            //    new Person { PersonId = 11, FirstName = "Paul", LastName ="Villalon", DateOfBirth =DateTime.Parse("5/24/1962"), Age =51, Sex = "male", PhoneNumber ="(08) 9024 5969" },
            //    new Person { PersonId = 12, FirstName = "Steven", LastName ="Thorpe", DateOfBirth =DateTime.Parse("2/11/1979"), Age =34, Sex = "male", PhoneNumber ="(03) 5376 0997" },
            //    new Person { PersonId = 13, FirstName = "Vernon", LastName ="Pavon", DateOfBirth =DateTime.Parse("10/22/1929"), Age =84, Sex = "male", PhoneNumber ="(02) 4047 0075" },
            //    new Person { PersonId = 14, FirstName = "Marilyn", LastName ="Gonzales", DateOfBirth =DateTime.Parse("11/28/1933"), Age =80, Sex = "female", PhoneNumber ="(03) 6297 4227" },
            //    new Person { PersonId = 15, FirstName = "Amy", LastName ="Decaro", DateOfBirth =DateTime.Parse("9/23/1949"), Age =64, Sex = "female", PhoneNumber ="(02) 9365 3409" },
            //    new Person { PersonId = 16, FirstName = "Margie", LastName ="Miller", DateOfBirth =DateTime.Parse("9/23/1938"), Age =75, Sex = "female", PhoneNumber ="(07) 4560 2433" },
            //    new Person { PersonId = 17, FirstName = "Vanessa", LastName ="Higgins", DateOfBirth =DateTime.Parse("9/26/1963"), Age =50, Sex = "female", PhoneNumber ="(03) 9976 6789" },
            //    new Person { PersonId = 18, FirstName = "Yetta", LastName ="Howard", DateOfBirth =DateTime.Parse("10/10/1976"), Age =37, Sex = "female", PhoneNumber ="(08) 9415 3661" },
            //    new Person { PersonId = 19, FirstName = "Wyatt", LastName ="Moss", DateOfBirth =DateTime.Parse("7/18/1959"), Age =54, Sex = "male", PhoneNumber ="(03) 5363 8402" },
            //    new Person { PersonId = 20, FirstName = "David", LastName ="Garcia", DateOfBirth =DateTime.Parse("10/18/1955"), Age =58, Sex = "male", PhoneNumber ="(03) 5358 7578" },
            //    new Person { PersonId = 21, FirstName = "James", LastName ="Curtis", DateOfBirth =DateTime.Parse("7/30/1988"), Age =25, Sex = "male", PhoneNumber ="(07) 4585 3499" },
            //    new Person { PersonId = 22, FirstName = "John", LastName ="Shepard", DateOfBirth =DateTime.Parse("4/4/1942"), Age =71, Sex = "male", PhoneNumber ="(08) 8730 3693" },
            //    new Person { PersonId = 23, FirstName = "Mallory", LastName ="Morrison", DateOfBirth =DateTime.Parse("5/23/1946"), Age =67, Sex = "female", PhoneNumber ="(02) 4707 9496" },
            //    new Person { PersonId = 24, FirstName = "Hanna", LastName ="Bullock", DateOfBirth =DateTime.Parse("9/26/1976"), Age =37, Sex = "female", PhoneNumber ="(02) 4011 8171" },
            //    new Person { PersonId = 25, FirstName = "John", LastName ="Pratt", DateOfBirth =DateTime.Parse("1/28/1934"), Age =79, Sex = "male", PhoneNumber ="(08) 9479 7086" },
            //    new Person { PersonId = 26, FirstName = "Freddie", LastName ="Rogge", DateOfBirth =DateTime.Parse("2/27/1931"), Age =82, Sex = "female", PhoneNumber ="(07) 4046 8355" },
            //    new Person { PersonId = 27, FirstName = "Betty", LastName ="Moses", DateOfBirth =DateTime.Parse("4/8/1975"), Age =38, Sex = "female", PhoneNumber ="(02) 6172 5097" },
            //    new Person { PersonId = 28, FirstName = "Douglas", LastName ="Dickens", DateOfBirth =DateTime.Parse("3/30/1959"), Age =54, Sex = "male", PhoneNumber ="(07) 4526 5439" },
            //    new Person { PersonId = 29, FirstName = "Elinor", LastName ="Johnson", DateOfBirth =DateTime.Parse("10/2/1950"), Age =63, Sex = "female", PhoneNumber ="(08) 9058 6307" },
            //    new Person { PersonId = 30, FirstName = "Paul", LastName ="Wade", DateOfBirth =DateTime.Parse("8/12/1955"), Age =58, Sex = "male", PhoneNumber ="(03) 5350 3047" },
            //    new Person { PersonId = 31, FirstName = "Michele", LastName ="Byrd", DateOfBirth =DateTime.Parse("10/29/1993"), Age =20, Sex = "female", PhoneNumber ="(08) 8250 9348" },
            //    new Person { PersonId = 32, FirstName = "Dale", LastName ="Mendez", DateOfBirth =DateTime.Parse("3/2/1932"), Age =81, Sex = "male", PhoneNumber ="(07) 4046 9028" },
            //    new Person { PersonId = 33, FirstName = "Anthony", LastName ="Ferrer", DateOfBirth =DateTime.Parse("8/15/1945"), Age =68, Sex = "male", PhoneNumber ="(07) 4519 1790" },
            //    new Person { PersonId = 34, FirstName = "William", LastName ="Glass", DateOfBirth =DateTime.Parse("6/17/1982"), Age =31, Sex = "male", PhoneNumber ="(02) 9814 6796" },
            //    new Person { PersonId = 35, FirstName = "William", LastName ="Burke", DateOfBirth =DateTime.Parse("12/24/1951"), Age =62, Sex = "male", PhoneNumber ="(02) 4606 0088" },
            //    new Person { PersonId = 36, FirstName = "Billie", LastName ="Turner", DateOfBirth =DateTime.Parse("1/21/1990"), Age =23, Sex = "female", PhoneNumber ="(07) 5686 0649" },
            //    new Person { PersonId = 37, FirstName = "Kyle", LastName ="Wilson", DateOfBirth =DateTime.Parse("7/1/1967"), Age =46, Sex = "male", PhoneNumber ="(02) 4620 7166" },
            //    new Person { PersonId = 38, FirstName = "Mary", LastName ="Leggett", DateOfBirth =DateTime.Parse("1/15/1934"), Age =79, Sex = "female", PhoneNumber ="(03) 9052 3444" },
            //    new Person { PersonId = 39, FirstName = "Steve", LastName ="Scharff", DateOfBirth =DateTime.Parse("12/24/1935"), Age =78, Sex = "male", PhoneNumber ="(02) 6725 6632" },
            //    new Person { PersonId = 40, FirstName = "Henry", LastName ="McCormack", DateOfBirth =DateTime.Parse("9/5/1987"), Age =26, Sex = "male", PhoneNumber ="(03) 5340 1107" },
            //    new Person { PersonId = 41, FirstName = "Cynthia", LastName ="Johnson", DateOfBirth =DateTime.Parse("12/2/1969"), Age =44, Sex = "female", PhoneNumber ="(02) 6743 7137" },
            //    new Person { PersonId = 42, FirstName = "Shirely", LastName ="Spencer", DateOfBirth =DateTime.Parse("9/17/1938"), Age =75, Sex = "female", PhoneNumber ="(02) 4972 6365" },
            //    new Person { PersonId = 43, FirstName = "Ethel", LastName ="Doe", DateOfBirth =DateTime.Parse("1/20/1968"), Age =45, Sex = "female", PhoneNumber ="(08) 8771 3112" },
            //    new Person { PersonId = 44, FirstName = "Robert", LastName ="Preston", DateOfBirth =DateTime.Parse("1/1/1990"), Age =23, Sex = "male", PhoneNumber ="(02) 4011 9822" },
            //    new Person { PersonId = 45, FirstName = "Daniel", LastName ="Mitchell", DateOfBirth =DateTime.Parse("8/3/1992"), Age =21, Sex = "male", PhoneNumber ="(02) 4942 5126" },
            //    new Person { PersonId = 46, FirstName = "Jimmie", LastName ="Burrell", DateOfBirth =DateTime.Parse("11/2/1928"), Age =85, Sex = "female", PhoneNumber ="(08) 8702 4788" },
            //    new Person { PersonId = 47, FirstName = "Michael", LastName ="Cook", DateOfBirth =DateTime.Parse("1/25/1967"), Age =46, Sex = "male", PhoneNumber ="(08) 9433 1419" },
            //    new Person { PersonId = 48, FirstName = "Amparo", LastName ="Byrnes", DateOfBirth =DateTime.Parse("2/9/1972"), Age =41, Sex = "female", PhoneNumber ="(02) 4910 5065" },
            //    new Person { PersonId = 49, FirstName = "Patricia", LastName ="Matthews", DateOfBirth =DateTime.Parse("1/21/1974"), Age =39, Sex = "female", PhoneNumber ="(02) 6118 5871" },
            //    new Person { PersonId = 50, FirstName = "Catherine", LastName ="Stockwell", DateOfBirth =DateTime.Parse("4/3/1941"), Age =72, Sex = "female", PhoneNumber ="(02) 4940 9986" },
            //    new Person { PersonId = 51, FirstName = "David", LastName ="Stump", DateOfBirth =DateTime.Parse("1/11/1975"), Age =38, Sex = "male", PhoneNumber ="(02) 4072 5836" },
            //    new Person { PersonId = 52, FirstName = "Lori", LastName ="Williams", DateOfBirth =DateTime.Parse("12/4/1988"), Age =25, Sex = "female", PhoneNumber ="(02) 6773 0502" },
            //    new Person { PersonId = 53, FirstName = "Randy", LastName ="Wilde", DateOfBirth =DateTime.Parse("7/2/1942"), Age =71, Sex = "male", PhoneNumber ="(07) 4948 2821" },
            //    new Person { PersonId = 54, FirstName = "Irene", LastName ="Moore", DateOfBirth =DateTime.Parse("9/8/1937"), Age =76, Sex = "female", PhoneNumber ="(08) 8702 5346" },
            //    new Person { PersonId = 55, FirstName = "Kristine", LastName ="Card", DateOfBirth =DateTime.Parse("6/3/1940"), Age =73, Sex = "female", PhoneNumber ="(02) 4032 9210" },
            //    new Person { PersonId = 56, FirstName = "Paul", LastName ="Lambert", DateOfBirth =DateTime.Parse("8/28/1984"), Age =29, Sex = "male", PhoneNumber ="(03) 6280 0921" },
            //    new Person { PersonId = 57, FirstName = "Abel", LastName ="Hardin", DateOfBirth =DateTime.Parse("5/21/1968"), Age =45, Sex = "male", PhoneNumber ="(02) 4096 8727" },
            //    new Person { PersonId = 58, FirstName = "William", LastName ="Mueller", DateOfBirth =DateTime.Parse("12/22/1948"), Age =65, Sex = "male", PhoneNumber ="(07) 4971 6591" },
            //    new Person { PersonId = 59, FirstName = "Vicky", LastName ="Conley", DateOfBirth =DateTime.Parse("12/18/1971"), Age =42, Sex = "female", PhoneNumber ="(08) 8298 1720" },
            //    new Person { PersonId = 60, FirstName = "Jay", LastName ="Schmitt", DateOfBirth =DateTime.Parse("7/10/1976"), Age =37, Sex = "male", PhoneNumber ="(07) 4592 8537" },
            //    new Person { PersonId = 61, FirstName = "Erma", LastName ="Hurley", DateOfBirth =DateTime.Parse("12/31/1990"), Age =23, Sex = "female", PhoneNumber ="(03) 5347 3985" },
            //    new Person { PersonId = 62, FirstName = "Mario", LastName ="Stein", DateOfBirth =DateTime.Parse("12/1/1986"), Age =27, Sex = "male", PhoneNumber ="(07) 4951 0955" },
            //    new Person { PersonId = 63, FirstName = "Clarence", LastName ="Arvizu", DateOfBirth =DateTime.Parse("3/17/1968"), Age =45, Sex = "male", PhoneNumber ="(03) 5301 8351" },
            //    new Person { PersonId = 64, FirstName = "Ralph", LastName ="Vaughan", DateOfBirth =DateTime.Parse("11/10/1956"), Age =57, Sex = "male", PhoneNumber ="(07) 4573 8847" },
            //    new Person { PersonId = 65, FirstName = "Miriam", LastName ="Paul", DateOfBirth =DateTime.Parse("5/19/1975"), Age =38, Sex = "female", PhoneNumber ="(03) 5373 1640" },
            //    new Person { PersonId = 66, FirstName = "Joanna", LastName ="Isaacs", DateOfBirth =DateTime.Parse("1/3/1994"), Age =19, Sex = "female", PhoneNumber ="(02) 4974 8089" },
            //    new Person { PersonId = 67, FirstName = "Luther", LastName ="Sullivan", DateOfBirth =DateTime.Parse("12/10/1940"), Age =73, Sex = "male", PhoneNumber ="(07) 3090 7574" },
            //    new Person { PersonId = 68, FirstName = "Joshua", LastName ="Kelly", DateOfBirth =DateTime.Parse("2/3/1930"), Age =83, Sex = "male", PhoneNumber ="(02) 4297 2747" },
            //    new Person { PersonId = 69, FirstName = "Patricia", LastName ="Billings", DateOfBirth =DateTime.Parse("3/12/1993"), Age =20, Sex = "female", PhoneNumber ="(03) 5304 5649" },
            //    new Person { PersonId = 70, FirstName = "Harry", LastName ="Allen", DateOfBirth =DateTime.Parse("1/26/1940"), Age =73, Sex = "male", PhoneNumber ="(07) 4065 6075" },
            //    new Person { PersonId = 71, FirstName = "Katrina", LastName ="Kimberly", DateOfBirth =DateTime.Parse("1/27/1945"), Age =68, Sex = "female", PhoneNumber ="(07) 3836 6086" },
            //    new Person { PersonId = 72, FirstName = "Glenda", LastName ="Humphrey", DateOfBirth =DateTime.Parse("10/20/1947"), Age =66, Sex = "female", PhoneNumber ="(07) 3809 3361" },
            //    new Person { PersonId = 73, FirstName = "George", LastName ="Cummings", DateOfBirth =DateTime.Parse("7/9/1983"), Age =30, Sex = "male", PhoneNumber ="(08) 9422 9758" },
            //    new Person { PersonId = 74, FirstName = "Melida", LastName ="Forbes", DateOfBirth =DateTime.Parse("5/17/1979"), Age =34, Sex = "female", PhoneNumber ="(03) 6223 4509" },
            //    new Person { PersonId = 75, FirstName = "Alice", LastName ="Collins", DateOfBirth =DateTime.Parse("2/25/1985"), Age =28, Sex = "female", PhoneNumber ="(07) 4970 9992" },
            //    new Person { PersonId = 76, FirstName = "Ann", LastName ="Lay", DateOfBirth =DateTime.Parse("3/25/1949"), Age =64, Sex = "female", PhoneNumber ="(03) 5370 6130" },
            //    new Person { PersonId = 77, FirstName = "Cleo", LastName ="Le", DateOfBirth =DateTime.Parse("12/9/1942"), Age =71, Sex = "female", PhoneNumber ="(03) 5355 3342" },
            //    new Person { PersonId = 78, FirstName = "Robert", LastName ="Lozano", DateOfBirth =DateTime.Parse("1/16/1951"), Age =62, Sex = "male", PhoneNumber ="(08) 8273 2889" },
            //    new Person { PersonId = 79, FirstName = "Dorthy", LastName ="Meadow", DateOfBirth =DateTime.Parse("4/25/1941"), Age =72, Sex = "female", PhoneNumber ="(07) 4064 2311" },
            //    new Person { PersonId = 80, FirstName = "Mark", LastName ="Montgomery", DateOfBirth =DateTime.Parse("4/14/1948"), Age =65, Sex = "male", PhoneNumber ="(08) 9016 0086" },
            //    new Person { PersonId = 81, FirstName = "Donald", LastName ="Brown", DateOfBirth =DateTime.Parse("6/1/1977"), Age =36, Sex = "male", PhoneNumber ="(07) 4515 4170" },
            //    new Person { PersonId = 82, FirstName = "Irene", LastName ="Wolf", DateOfBirth =DateTime.Parse("1/24/1931"), Age =82, Sex = "female", PhoneNumber ="(03) 5313 8442" },
            //    new Person { PersonId = 83, FirstName = "Robert", LastName ="Caballero", DateOfBirth =DateTime.Parse("12/5/1956"), Age =57, Sex = "male", PhoneNumber ="(02) 6704 0234" },
            //    new Person { PersonId = 84, FirstName = "Ray", LastName ="Jones", DateOfBirth =DateTime.Parse("3/23/1937"), Age =76, Sex = "male", PhoneNumber ="(02) 4606 7766" },
            //    new Person { PersonId = 85, FirstName = "Israel", LastName ="Packer", DateOfBirth =DateTime.Parse("11/19/1983"), Age =30, Sex = "male", PhoneNumber ="(02) 4056 9106" },
            //    new Person { PersonId = 86, FirstName = "Elijah", LastName ="Case", DateOfBirth =DateTime.Parse("8/27/1954"), Age =59, Sex = "male", PhoneNumber ="(03) 5395 8957" },
            //    new Person { PersonId = 87, FirstName = "Cassandra", LastName ="Waits", DateOfBirth =DateTime.Parse("4/12/1950"), Age =63, Sex = "female", PhoneNumber ="(02) 9637 5599" },
            //    new Person { PersonId = 88, FirstName = "William", LastName ="Torres", DateOfBirth =DateTime.Parse("8/20/1950"), Age =63, Sex = "male", PhoneNumber ="(07) 4098 1584" },
            //    new Person { PersonId = 89, FirstName = "Martin", LastName ="Ward", DateOfBirth =DateTime.Parse("2/17/1987"), Age =26, Sex = "male", PhoneNumber ="(02) 4981 7994" },
            //    new Person { PersonId = 90, FirstName = "David", LastName ="Heintzelman", DateOfBirth =DateTime.Parse("6/21/1939"), Age =74, Sex = "male", PhoneNumber ="(03) 5354 8746" },
            //    new Person { PersonId = 91, FirstName = "Angelo", LastName ="Regan", DateOfBirth =DateTime.Parse("6/30/1994"), Age =19, Sex = "male", PhoneNumber ="(08) 9022 3506" },
            //    new Person { PersonId = 92, FirstName = "Joel", LastName ="Frost", DateOfBirth =DateTime.Parse("4/1/1941"), Age =72, Sex = "male", PhoneNumber ="(02) 6761 5624" },
            //    new Person { PersonId = 93, FirstName = "Kelly", LastName ="Dougherty", DateOfBirth =DateTime.Parse("10/23/1990"), Age =23, Sex = "female", PhoneNumber ="(02) 6126 3839" },
            //    new Person { PersonId = 94, FirstName = "Jessica", LastName ="Frank", DateOfBirth =DateTime.Parse("1/2/1941"), Age =72, Sex = "female", PhoneNumber ="(07) 3831 8088" },
            //    new Person { PersonId = 95, FirstName = "Esther", LastName ="Mares", DateOfBirth =DateTime.Parse("7/9/1973"), Age =40, Sex = "female", PhoneNumber ="(07) 4087 2857" },
            //    new Person { PersonId = 96, FirstName = "Judith", LastName ="Stockton", DateOfBirth =DateTime.Parse("2/26/1971"), Age =42, Sex = "female", PhoneNumber ="(03) 5323 4891" },
            //    new Person { PersonId = 97, FirstName = "Samuel", LastName ="Shelton", DateOfBirth =DateTime.Parse("1/10/1983"), Age =30, Sex = "male", PhoneNumber ="(08) 8251 4242" },
            //    new Person { PersonId = 98, FirstName = "Ralph", LastName ="Sledge", DateOfBirth =DateTime.Parse("8/13/1948"), Age =65, Sex = "male", PhoneNumber ="(02) 6179 7114" },
            //    new Person { PersonId = 99, FirstName = "Diana", LastName ="Irwin", DateOfBirth =DateTime.Parse("5/1/1945"), Age =68, Sex = "female", PhoneNumber ="(03) 5300 3783" },
            //    new Person { PersonId = 100, FirstName = "Charles", LastName ="McDorman", DateOfBirth =DateTime.Parse("4/5/1970"), Age =43, Sex = "male", PhoneNumber ="(02) 4079 0387" },
            //    new Person { PersonId = 101, FirstName = "Rebekah", LastName ="Boyce", DateOfBirth =DateTime.Parse("2/4/1962"), Age =51, Sex = "female", PhoneNumber ="(03) 6281 0380" },
            //    new Person { PersonId = 102, FirstName = "Barbara", LastName ="Robinson", DateOfBirth =DateTime.Parse("5/19/1945"), Age =68, Sex = "female", PhoneNumber ="(02) 6181 7751" },
            //    new Person { PersonId = 103, FirstName = "Carol", LastName ="White", DateOfBirth =DateTime.Parse("12/24/1959"), Age =54, Sex = "female", PhoneNumber ="(08) 8702 7320" },
            //    new Person { PersonId = 104, FirstName = "John", LastName ="Hostetler", DateOfBirth =DateTime.Parse("9/18/1947"), Age =66, Sex = "male", PhoneNumber ="(03) 9094 3069" },
            //    new Person { PersonId = 105, FirstName = "Dennis", LastName ="Small", DateOfBirth =DateTime.Parse("10/23/1944"), Age =69, Sex = "male", PhoneNumber ="(03) 9610 6213" },
            //};

            //int i = 0;
            //Persons.ForEach(x => x.PersonId = ++i);


        }
    }
}

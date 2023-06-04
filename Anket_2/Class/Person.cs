using MyLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket_2.Class
{
    internal class Person
    {
		//  Name
		private string _name;
		public string Name
		{
			get { return _name; }
			set 
			{
				if (MyRegex.CheckLettersStartWithUppercase(value))
				{
					_name = value;
				}
				else
				{
					throw new Exception("Invalid name!");
				}
			}
		}

		//  Surname
		private string _surname;
		public string Surname
		{
			get { return _surname; }
			set 
			{
				if (MyRegex.CheckLettersStartWithUppercase(value))
				{
                    _surname = value;
				}
				else
				{
					throw new Exception("Invalid surname!");
				}
			}
		}

		//  Surname
		private string _email;
		public string Email
		{
			get { return _email; }
			set 
			{
				if (MyRegex.CheckEmail(value))
				{
                    _email = value;
				}
				else
				{
					throw new Exception("Invalid email!");
				}
			}
		}

		//  Surname
		private string _phone;

        public string Phone
		{
			get { return _phone; }
			set 
			{
				if (MyRegex.CheckPhone(value))
				{
                    _phone = value;
				}
				else
				{
					throw new Exception("Invalid phone!");
				}
			}
		}
        public Person(string name, string surname, string email, string phone, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        //	Birthday
        public DateTime Birthday { get; set; }



	}
}

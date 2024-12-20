using System;
namespace FieldAndProperty.Entity
{
	public class Employee
	{
		private string _firstName;

        //enkapsulyasiya tətbiqi
        public string FirstName
		{
			get => _firstName;
			set => _firstName = value;
		}
	}
}


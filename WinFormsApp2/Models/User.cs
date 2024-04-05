using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

namespace WinFormsApp2.Models;

public class User
{
	private string _name;

	public string Name
	{
		get { return _name; }
		set { if (_name.Length < 3 && _name.Length > 18) throw new Exception("Name is wrong"); _name = value; }
	}
	private string _surname;

	public string Surname
	{
		get { return _surname; }
		set { if (_surname.Length < 3 && Name.Length > 18) throw new Exception("Surname is wrong"); _surname = value; }
	}

	private string _country;
	public string Country
	{
		get { return _country; }
		set { if (_country.Length < 3 && _country.Length > 18) throw new Exception("Country is wrong"); _country = value; }
	}

	private string  profession;

	public string  Profession
	{
		get { return profession; }
		set { if (profession.Length < 3 && profession.Length > 15) throw new Exception("profession is wrong"); profession = value; }
	}

    private string _city;
    public string City
    {
        get { return _city; }
        set { if (_city.Length < 3 && _city.Length > 18) throw new Exception("City is wrong"); _city = value; }
    }


    private string _phone;
    public string Phone
    {
        get { return _phone; }
        set { if (_phone.Length < 3 && _phone.Length > 18) throw new Exception("Phone is wrong"); _city = value; }
    }

	public DateTime Date { get; set; }
	public string male { get;set; }

    public User(string name, string surname, string country, string profession, string city, string phone, DateTime date, string male)
    {
        Name = name;
        Surname = surname;
        Country = country;
        Profession = profession;
        City = city;
        Phone = phone;
        Date = date;
        this.male = male;
    }
    public User()
    {
        _name = string.Empty;
        _surname = string.Empty;
        _phone = string.Empty;
        _city = string.Empty;
        male = string.Empty;
        Date = new();
    }

    public override string ToString()
    {
        return $"Name: {Name}\nSurname: {Surname}\nProfession: {Profession}\nCountry: {Country}\nCity: {City}\nPhone: {Phone}\nDate: {Date}\nMale: {male}";
    }

}

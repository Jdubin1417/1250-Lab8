/**
*--------------------------------------------------------------------
* File name: PersonalInformation.cs
* Project name: lab8
*--------------------------------------------------------------------
* Author’s name and email: Justin Dubin, dubinj@etsu.edu
* Course-Section: CSCI 1250-001
* Creation Date: 14 Apr 2022
*
-------------------------------------------------------------------
*/
public class PersonalInformation
{
    private string _name;
    private string _address;
    private int _age;
    private int _phoneNumber;


    public PersonalInformation(string name, string address, int age, int phoneNumber)
    {
         _name = name;
        _address = address;
        _age = age;
        _phoneNumber = phoneNumber;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address;
    }

    public int GetAge()
    {
        return _age;
    }

    public int GetPhoneNumber()
    {
        return _phoneNumber;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAddress(string address)
    {
        _address = address;
    }

    public void SetAge(int age)
    {
        _age = age;
    }

    public void SetPhoneNumber(int phoneNumber)
    {
        _phoneNumber = phoneNumber;
    }
}
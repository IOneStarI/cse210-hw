using System;
using System.Collections.Generic;

class Address
{
    private string street;
    private string city;
    private string country;

    public Address(string street, string city, string country)
    {
        this.street = street;
        this.city = city;
        this.country = country;
    }

    public bool IsInUkraine()
    {
        return country.ToLower() == "ukr";
    }

    public string GetFullAddress()
    {
        return $"{street}\n{city}, \n{country}";
    }
}
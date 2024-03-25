using System.Collections.Concurrent;

public class Customer {
    private string customer_name;
    private Address address;

    public Customer(string customer_name, Address address){
        this.customer_name = customer_name;
        this.address = address;
    }

    public string CountryName(){
        var country = address.GetCountry();
        return country;
    }

    public string CustomerName(){
        return customer_name;
    }

    public string Address(){
        var fullAddress = address.GetAddress();
        return fullAddress;
    }
}
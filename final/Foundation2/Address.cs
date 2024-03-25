public class Address {
    private string street_address;
    private string city_name;
    private string state_providence_name;
    private string country_name;

    public Address(string street_address, string city_name, string state_providence_name, string country_name){
        this.street_address = street_address;
        this.city_name = city_name;
        this.state_providence_name = state_providence_name;
        this.country_name = country_name;
    }

    public string GetCountry(){
        return country_name;
    }

    public string GetAddress(){
        return $"{street_address} \n {city_name}, {state_providence_name} \n {country_name}";
    }
}
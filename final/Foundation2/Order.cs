using System.Collections.Concurrent;

public class Order {
    private List <Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer){
        this.products = products;
        this.customer = customer;
    }

    public int TotalCosts(){
        int totalPrice = 0;
        foreach (var product in products){
                var price = product.QuantityPriceCaluclator();
                totalPrice += price;
            }
        return totalPrice;
    }

    public int ShippingPrice(){
        int price = TotalCosts();
        if (customer.CountryName() == "USA"){
            int shippingPrice = 5;
            shippingPrice += price;
            return shippingPrice;
        }
        else {
            int shippingPrice = 35;
            shippingPrice += price;
            return shippingPrice;
        }
    }

    public void PackingLabel(){
        foreach (var product in products){
                string packingInfo = $"{product.GetProductName()} \n ID: {product.GetProductID()}";
                System.Console.WriteLine(packingInfo);
        }
    }
        

    public string ShippingLabel(){
        string shippingLabel = $"{customer.CustomerName()} \n {customer.Address()}";
        return shippingLabel;
    }

    public string TotalPrice(){
        int finalPrice = ShippingPrice();
        string priceSummary = $"Total Price: ${finalPrice}";
        return priceSummary;
    }
}
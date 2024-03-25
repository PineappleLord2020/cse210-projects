public class Product {
    private string product_name;
    private int product_id;
    private int price_per_unit;
    private int quantity;
    
    public Product(string product_name, int product_id, int price_per_unit, int quantity){
        this.product_name = product_name;
        this.product_id = product_id;
        this.price_per_unit = price_per_unit;
        this.quantity = quantity;
    }

    public int QuantityPriceCaluclator() {
        int calculatedPrice = quantity * price_per_unit;
        return calculatedPrice;
    }

    public int GetPrice(){
        return price_per_unit;
    }

    public string GetProductName(){
        return product_name;
    }

    public int GetProductID(){
        return product_id;
    }
}
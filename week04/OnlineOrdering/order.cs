using System.Globalization;

public class Order {
List<Product> _products = new List<Product>();
Customer _customer;
public Order(Customer customer){
    _customer=customer;
}
public void AddProduct(string name, string productId, float price, int quantity){
        Product product=new Product(name, productId, price, quantity);
        _products.Add(product);
}
public string GetPackingLabel() {
string label = "";
foreach (Product p in _products) {
label = $"{label} {p.GetLabel()}:";
}
return label;
}
public string getShippingLabel() {
return $"{_customer.GetName()} {_customer.GetAddress()}";
}
public float GetTotalCost(){
    float total = 0;
        foreach (Product product in _products){
        total = total + product.GetTotalAmount();
}
if(_customer.IsInUSA()){
    total+=5;
}
else{
    total+=35;
}
return total;
}
}

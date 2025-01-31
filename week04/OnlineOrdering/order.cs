public class Order {
List<Products> _products = new List<Products>();
Customer _customer;
public string GetPackingLabel() {
string label = "";
foreach (Product p in _products) {
label = $"{label} {p.GetLabel()}:";
}
return label;
}
public string getShippingLabel() {
return $"{_customer.getName()} {_customer.getAddress()}";
}
public float GetTotalCost(){
    float total = 0;
        foreach (Product product in _products){
        total = total + product.GetTotalAmount();
}
}
}

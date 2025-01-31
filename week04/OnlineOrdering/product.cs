public class Product {
string _name;
string _productId;
float _price;
int _quantity;

public float GetTotalAmount() {
return _price * _quantity;
}
public string GetLabel(){
return $”{_productId}: {_name}”;
}

}

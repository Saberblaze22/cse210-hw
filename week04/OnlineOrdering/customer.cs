public class Customer {
string _name;
Address _address;
public Customer(string name, Address address){
    _name=name;
    _address=address;
}
public bool IsInUSA() {
bool us = _address.IsInUSA();
return us;
}	
public string GetName(){
    return _name;
}
public string GetAddress(){
    return _address.GetAddress();
}
}

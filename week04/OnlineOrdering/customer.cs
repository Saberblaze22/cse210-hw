public class Customer {
string _name { get; set; }
Address _address;

public bool IsInUSA() {
bool us = _address.IsInUSA();
return us;
}	
}

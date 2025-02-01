public class Address {
string _address;
string _city;
string _state;
string _country;
public Address(string address, string city, string state, string country){
    _address=address;
    _city=city;
    _country=country;
    _state=state;
}
public String GetAddress(){
    return $"{_address}: {_city}: {_state}: {_country}";
}

public bool IsInUSA(){
    if(_country.ToLower()=="usa"){
        return true;
    }
    else{
        return false;
    }
}
}

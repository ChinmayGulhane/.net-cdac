namespace BOL;

public class Company{
    public int company_id{get; set;}
    public string company_name{get; set;}   
    public string company_city{get; set;}

    public Company(){

    }

    public Company(int company_id, string company_name, string company_city){
        this.company_id=company_id;
        this.company_name=company_name;
        this.company_city=company_city;
    }
}
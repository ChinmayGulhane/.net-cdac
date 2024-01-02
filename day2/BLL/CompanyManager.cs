namespace BLL;
using BOL;
using DAL;
public class CompanyManager{
    public List<Company> getAllComp(){
        List<Company> compAll = new List<Company>();
        compAll = DBManager.getAllComp();
        return compAll;
    }

    

}
namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public class DBManager{

public static string constring=@"server=192.168.10.150; port=3306; user=dac16; password=welcome; database=dac16";
    public static List<Company> getAllComp(){
        List<Company> coy = new List<Company>();
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=constring;
        string qur="Select * from company";
        try
        {
                    MySqlCommand cmd=new MySqlCommand();
                    cmd.Connection=conn;
                    conn.Open();
                    cmd.CommandText=qur;
                    MySqlDataReader rdr= cmd.ExecuteReader();
                    while(rdr.Read()){
                        int id=int.Parse(rdr["company_id"].ToString());
                        string name= rdr["company_name"].ToString();
                        string city= rdr["company_city"].ToString();

                        Company c = new Company{company_id = id, company_name = name, company_city=city};
                        coy.Add(c);
                    } 
        }
        catch (Exception e )
        {
            Console.WriteLine(e.Message);
        }
        finally{
            conn.Close();
        }

    return coy;
    }
}
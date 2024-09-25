namespace BookstoreManager.Requests;

public enum GenderBook
{
    fiction,
    romance, 
    mystery
}
public class BookRegisterJson
{
    public int Id;
    public string Title { get; set; } = string.Empty;   
    public double Price { get; set; }   
    public int QuantityInStock { get; set; }
    public GenderBook Gender { get; set; }


}

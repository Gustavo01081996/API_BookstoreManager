namespace BookstoreManager.Requests;

public class BookUpdateBookJson
{
    public string Title { get; set; } = string.Empty;
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    public GenderBook Gender;
}

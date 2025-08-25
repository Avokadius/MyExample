namespace LibraryManagementSystemExample;

public class Magazine : Library
{
    public string Edition { get; set; }

    public Magazine(string name,string author,string edition,bool inStock = true) :base (name,author,inStock)
    {
        Edition = edition;   
    }

    public override string GetInfo()
    {
        return $"{ BaseInfo()}, Издание: { Edition}";
    }

}




using System.ComponentModel.DataAnnotations.Schema;

namespace StoreInfo.Domian.Stores;

public class Store
{
    public long id { get; set; }
    [Column(TypeName = "char(4)")]
    public char code { get; set; }
    public long region_id { get; set; }
    public long State_id { get; set; }
    public long city_id { get; set; }
    public string name { get; set; }
    public string address { get; set; }
    public double longitude { get; set; }
    public double latitude { get; set; }
    public List<PostalCode> postalCodes { get; set; }
}

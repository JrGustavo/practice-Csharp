

var sale = new SaleWithTax(15);
var message = sale.GetInfo();


Console.WriteLine(message);

class SaleWithTax : Sale
{
    public SaleWithTax(decimal total) : base(total)
    {
    }
    
}

class Sale
{
    public decimal Total { get; set;  }
    
    public Sale(decimal total)
    {
        Total = total;
    }   
    
    public string GetInfo()
    {
        return "El Total es " + Total; 
    }
}


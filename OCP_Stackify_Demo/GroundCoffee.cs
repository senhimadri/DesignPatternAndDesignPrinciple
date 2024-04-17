namespace OCP_Stackify_Demo;

public class GroundCoffee
{
	private string name;
	private int quantity;
	public GroundCoffee(string _name,int _quantity)
	{
		name = _name;
		quantity = _quantity;
	}
	public string GetName()
	{
		return name;
	}

	public int GetQuantity()
	{
		return quantity;
	}

	public void SetQuantity(int _quantity)
	{
		quantity = _quantity;
	}
}
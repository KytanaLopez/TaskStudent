using System;

public class Inventario : AreasEmpresas
{

	//Atributos

	public int totalStock {  get; set; }
	public DateTime fechaInventario { get; set; }
	public string ubicacionStock { get; set; }

	//Constructor vacío

	public Inventario() { }

	//Constructor de atributos

	public Inventario(int totalStock, DateTime fechaInvenrio, string ubicacionStock)
	{
		this.totalStock = totalStock;
		this.fechaInventario = fechaInvenrio;
		this.ubicacionStock = ubicacionStock;
		
	}
    //Métodos (polimórficos: override)

    public override void mostrarAreas()
    {
        base.mostrarAreas();

		Console.WriteLine($"El total de Stock es: {totalStock}, la fecha del inventario es: {fechaInventario:dd/MM/yyyy} y su ubicación es: {ubicacionStock} ");
    }
	
}

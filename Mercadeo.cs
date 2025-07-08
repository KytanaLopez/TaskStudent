using System;

public class Mercadeo : AreasEmpresas
{
	//Atributos 

	public string lineaMercadeo {  get; set; }
	public int totalMercadeo { get; set; }

    //Constructor vacío
    public Mercadeo () { }

    //Constructor de atributos
    public Mercadeo(string lineaMercadeo, int totalMercadeo)
    {
        this.lineaMercadeo = lineaMercadeo;
        this.totalMercadeo = totalMercadeo;
    }

    //Métodos - Polimorfismo

    public override void mostrarAreas()
    {
        base.mostrarAreas();

        Console.WriteLine($"La línea de mercado es: {lineaMercadeo} y el total de productos en línea de mercado es: {totalMercadeo}");
    }

}

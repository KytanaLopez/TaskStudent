using System;

public class Produccion : AreasEmpresas
{
	//Atributos
	public string lineaProduccion {  get; set; }
	public int totalProduccion {  set; get; }

	//Constructor vacío

	public Produccion() { }

	//Constructor de atributos

	public Produccion(string lineaProduccion, int totalProduccion) {
		this.lineaProduccion = lineaProduccion;
		this.totalProduccion= totalProduccion;
	}
    //Métodos (override) - polimorfismo

    public override void mostrarAreas()
    {
        base.mostrarAreas();
		Console.WriteLine($"La línea de producción es: {lineaProduccion} y el total de productos en línea de producción es: {totalProduccion} ");
    }
	
}

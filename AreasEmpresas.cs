using System;

public class AreasEmpresas
{
	//Atributos

	public int idArea {  get; set; }
	public string nombreArea { get; set; }
	public string responsableArea { get; set; }

	//Constructor vacío

	public AreasEmpresas() { }

	//Constructor de atributos

	public AreasEmpresas (int idArea, string nombreArea, string responsableArea)
	{
		this.idArea = idArea;
		this.nombreArea = nombreArea;
		this.responsableArea = responsableArea;
	}

	//Métodos

	public virtual void mostrarAreas()
	{
		Console.WriteLine($"El id del área {nombreArea} es: {idArea} y el responsable es: {responsableArea}");
	}

    public virtual void reporteFinanciero()
    {
        Console.WriteLine($"El siguiente es el reporte financiero (Gráficas)");
    }

    public virtual void informeFinanciero()
    {
        Console.WriteLine($"Este es el informe financiero");
    }



}

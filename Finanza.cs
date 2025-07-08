using System;

public class Finanza : AreasEmpresas
{

	//Atributos

	public double ingresosFinancieros {  get; set; }
	public double egresosFinancieros { get; set; }
	public double utilidadNeta {  get; set; }
	public DateTime fechaFinanza { get; set; }

	//Constructor vacío
	public Finanza() { }
	//Constructor de atributos
	public Finanza(double ingresosFinancieros, double egresosFinancieros, double utilidadNeta, DateTime fechaFinanza)
	{
		this.ingresosFinancieros = ingresosFinancieros;
		this.egresosFinancieros = egresosFinancieros;
		this.utilidadNeta = utilidadNeta;
		this.fechaFinanza = fechaFinanza;

	}
	//Métodos - Polimorfismo

	

    public override void mostrarAreas()
    {
        base.mostrarAreas();

		Console.WriteLine($"Fecha: {fechaFinanza:dd/MM/yyyy}");
		Console.WriteLine($"Los ingresos a la fecha son: {ingresosFinancieros}");
        Console.WriteLine($"Los egresos a la fecha son: {egresosFinancieros}");
        Console.WriteLine($"La utilidad neta a la fecha es: {utilidadNeta}");

    }
    public override void informeFinanciero()
    {
        base.informeFinanciero();
    }
    public override void reporteFinanciero()
    {
        base.reporteFinanciero();
    }
}

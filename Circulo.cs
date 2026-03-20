using System;

public class Circulo : Figura
{
	private double radio;

	public Circulo(double radio)
	{
		this.radio = radio;
	}

	public override double CalcularArea()
	{
		double area = Math.PI * radio * radio;
		return Math.Round(area, 2);
	}
}
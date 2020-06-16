using System;
using System.Security.Cryptography.X509Certificates;

namespace NDireccion
{
	public class Direccion
	{
		public int IDDireccion { get; set; }
		public string Direccion { get; set; }
		public string Localidad { get; set; }
		public double Coordx { get; set; }
		public double Coordy { get; set; }
	}
}

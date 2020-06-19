using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace NDireccion
{
	public class Direccion
	{
		[Key]
		public int IDDireccion { get; set; }
		public string Calle { get; set; }
		public string Localidad { get; set; }
		public double Coordx { get; set; }
		public double Coordy { get; set; }
	}
}

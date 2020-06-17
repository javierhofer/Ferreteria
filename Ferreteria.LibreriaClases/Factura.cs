using NTipoFactura;
using System;
using System.Security.Cryptography.X509Certificates;


namespace NFactura
{
	public class Factura
	{
		public int IDFactura { get; set; }
		public int NumFactura { get; set; }
		public DateTime FechaFactura { get; set; }
		public TipoFactura ClaseFactura {get;set;}
	}
}

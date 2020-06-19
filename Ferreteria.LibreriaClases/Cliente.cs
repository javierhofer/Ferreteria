using System;
using System.ComponentModel.DataAnnotations;

namespace NCliente
{
	public class Cliente
	{
		[Key]
		public int IDCliente { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
	}	
	
	
}

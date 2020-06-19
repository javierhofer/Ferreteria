using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace NCategoria
{
	public class Categoria
	{
		[Key]
		public int CategoriaID { get; set; }
		public string NombreCategoria { get; set; } 

	}
}
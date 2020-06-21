﻿using System;
using System.ComponentModel.DataAnnotations;

namespace NProducto
{
	public class Producto
	{
		[Key]
		public int IDProducto { get; set; }
		public int IDCategoria { get; set; }
		public string NombreProducto { get; set; }
		public int Precio { get; set; }
		public int Stock { get; set; }

	
	}
}

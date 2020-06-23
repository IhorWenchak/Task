using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace surface.Models
{
	class Surface
	{
		
		public double Height { get; set; }
		public double Width { get; set; }
		public double MainSquare 
		{
			get 
			{
				return Height * Width;
			}
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace surface.Models
{
	public class Surface
	{
		
		public double Height { get; set; }
		public double Width { get; set; }
		public double ContainerWidth { get; set; }
		public double ContainerHeight { get; set; }

		public double MainSquare 
		{
			get 
			{
				return ContainerHeight * ContainerWidth;
			}
		}

		public double Volume { get; set; }

		public Node Position { get; set; }

	}
}

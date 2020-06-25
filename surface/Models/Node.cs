using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace surface.Models
{
	public class Node
	{
		public Node RightNode { get; set; }
		public Node BottomNode { get; set; }
		public double Pos_x { get; set; }
		public double Pos_y { get; set; }
		public double Width { get; set; }
		public double Height { get; set; }
		public bool IsOccupied { get; set; }

	}
}

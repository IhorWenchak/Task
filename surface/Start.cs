using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using surface.Models;

namespace surface
{
	public partial class Start : Form
	{
		double height = 0;
		double width = 0;
		int quantity = 0;
		private Dictionary<int, double[]> dict = new Dictionary<int, double[]> ();
		double areaOfPieces = 0;

		public Start()
		{
			InitializeComponent();	
	    }

		private void Start_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Surface surf = new Surface();
			surf.Height = height;
			surf.Width = width;

			for(int i = 0; i < quantity; i++)
			{
				Rectangle f = new Rectangle(i + 1); // створюємо об’єкт типу Rectangle				
				f.ShowDialog();
				dict.Add(i+1, f.MyMas);
			}

			foreach(KeyValuePair<int, double[]> keyValue in dict)
			{	

				if((keyValue.Value[0] > surf.Height) || (keyValue.Value[0] > surf.Width) || (keyValue.Value[1] > surf.Height) || (keyValue.Value[1] > surf.Width))
				{
					MessageBox.Show(String.Format("One side of the rectangle № {0} is too large !", keyValue.Key.ToString()));
				}
				areaOfPieces += keyValue.Value[2];				
			}	

			if (areaOfPieces > surf.MainSquare)
			{
				MessageBox.Show("The area of the pieces is larger than the surface area !");
			}
		}

		private void Run(Rectangle rectangle)
		{
			throw new NotImplementedException();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void heightField_TextChanged(object sender, EventArgs e)
		{
			if (!double.TryParse(heightField.Text, out height)) 
			{
				MessageBox.Show("The height value will not be allowed!");
				heightField.Text = "0";
				height = 0;
			}
			else
			{				
				heightField.Text = height.ToString();
			}
		}

		private void widthField_TextChanged(object sender, EventArgs e)
		{
			if ((!double.TryParse(widthField.Text, out width)))
			{
				MessageBox.Show("The width value will not be allowed!");
				widthField.Text = "0";
				width = 0;
			}
			else
			{
				widthField.Text = width.ToString();
			}
		}

		private void quantityField_TextChanged(object sender, EventArgs e)
		{
			if ((!int.TryParse(quantityField.Text, out quantity)))
			{				
				MessageBox.Show("The quantity value will not be allowed!");
				quantityField.Text = "0";
				quantity = 0;
			}
			else
			{				
				quantityField.Text = quantity.ToString();
			}
			
		}		
	}
}

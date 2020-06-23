using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using surface;
using surface.Models;

namespace surface
{
	public partial class Rectangle : Form
	{
		double height = 0;
		double width = 0;
		int elem = 0;
		private double[] _myMas =  new double[3] ;

		public Rectangle(int i)
		{
			InitializeComponent();
			label1.Text = String.Format("Rectangl № {0}", i.ToString());
			elem = i;
		}

		private void Rectangle_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Surface sqr = new Surface();
			sqr.Height = height;
			sqr.Width = width;
			
			MyMas[0] = sqr.Height;
			MyMas[1] = sqr.Width;
			MyMas[2] = sqr.MainSquare;
			Close();
		}

		private void heightField_TextChanged(object sender, EventArgs e)
		{
			if ((!double.TryParse(heightField.Text, out height)))
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

		public double[] MyMas 
			{
			get 
				{
				return _myMas;
				}
			set 
				{
				_myMas = value;
				}
			}
	}
}

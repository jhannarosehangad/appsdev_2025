using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

			string[] cartoonChar = { "Spongebob", "Patrick", "Mr. Krabs", "Sandy" };
			comboBox.Items.AddRange(cartoonChar);

			comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			comboBox.SelectedIndex = 0;
		}

		private void viewBtn_Click(object sender, EventArgs e)
		{

			string selectedItem = comboBox.SelectedItem.ToString();

			switch (selectedItem)
			{
				case "Spongebob":
					pictureBox.Image = Image.FromFile(@"C:/Users/Aljhon/OneDrive/Pictures/spongebob.jpg");
					break;

				case "Patrick":
					pictureBox.Image = Image.FromFile(@"C:/Users/Aljhon/OneDrive/Pictures/patrick.jpg");
					break;

				case "Mr. Krabs":
					pictureBox.Image = Image.FromFile(@"C:/Users/Aljhon/OneDrive/Pictures/krab.jpg");
					break;

				case "Sandy":
					pictureBox.Image = Image.FromFile(@"C:/Users/Aljhon/OneDrive/Pictures/sandy.jpg");
					break;

				default:
					pictureBox.Image = null;
					break;
			}
		}

		private void clearBtn_Click(object sender, EventArgs e)
		{
			pictureBox.Image = null;
		}
	}
	}


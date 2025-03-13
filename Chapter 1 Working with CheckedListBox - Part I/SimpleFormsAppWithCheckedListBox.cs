using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
			
			string[] movies = { "The Simpsons", "Rick and Morty", "Squid Game", "Venom" };
			movieCheckListBox.Items.AddRange(movies);

			movieCheckListBox.CheckOnClick = true;
		}

		private void movieCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			foreach (var movie in movieCheckListBox.Items)
			{
				bool isSelected = movieCheckListBox.GetItemChecked(movieCheckListBox.Items.IndexOf(movie));
				if (isSelected && !movieListBox.Items.Contains(movie))
				{
					movieListBox.Items.Add(movie);
				}
			}
		}

		private void removeBtn_Click(object sender, EventArgs e)
		{
			if (movieListBox.Items.Count >= 1)
			{
				movieListBox.Items.Remove(movieListBox.SelectedItem);
			}
		}

		private void clearBtn_Click(object sender, EventArgs e)
		{
			movieListBox.Items.Clear();
		}
	}
}

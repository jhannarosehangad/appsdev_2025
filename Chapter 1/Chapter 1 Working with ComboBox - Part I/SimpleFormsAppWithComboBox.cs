using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithComboBox
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

			string[] foodGenre = { "Filipino", "Japanese", "Chinese", "Korean" };
			foodComboBox.Items.AddRange(foodGenre);

			foodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			foodComboBox.SelectedIndex = 0;

			foodCheckedListBox.CheckOnClick = true;
		}

		private void selectBtn_Click(object sender, EventArgs e)
		{
			string[] filipinoFoodList = { "Bulalo", "Kare-Kare", "Bicol Express", "Pinakbet" };
			string[] japaneseFoodList = { "Sushi", "Ramen", "Gyoza", "Shabu-shabu" };
			string[] chineseFoodList = { "Chow Mein", "Peking Duck", "Kung Pao Chicken", "Spring Rolls" };
			string[] koreanFoodList = { "Kimchi-jjigae", "Naengmyeon", "Jajangmyeon", "Bulgogi" };


			foodCheckedListBox.Items.Clear();

			if (foodComboBox.SelectedItem.ToString().Contains("Filipino"))
			{
				foodCheckedListBox.Items.AddRange(filipinoFoodList);
			}
			else if (foodComboBox.SelectedItem.ToString().Contains("Japanese"))
			{
				foodCheckedListBox.Items.AddRange(japaneseFoodList);
			}
			else if (foodComboBox.SelectedItem.ToString().Contains("Chinese"))
			{
				foodCheckedListBox.Items.AddRange(chineseFoodList);
			}
			else if (foodComboBox.SelectedItem.ToString().Contains("Korean"))
			{
				foodCheckedListBox.Items.AddRange(koreanFoodList);
			}
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			foreach (var item in foodCheckedListBox.Items)
			{
				bool isSelected = foodCheckedListBox.GetItemChecked(foodCheckedListBox.Items.IndexOf(item));
				if (isSelected && !foodListBox.Items.Contains(item))
				{
					foodListBox.Items.Add(item);

				}
			}
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			if (foodListBox.Items.Count >= 1)
			{
				foodListBox.Items.Remove(foodListBox.SelectedItem);
			}
		}

		private void clearBtn_Click(object sender, EventArgs e)
		{
			foodListBox.Items.Clear();
		}
	}
}

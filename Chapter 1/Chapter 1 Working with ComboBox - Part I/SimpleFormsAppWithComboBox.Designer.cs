namespace SimpleFormsAppWithComboBox
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.foodComboBox = new System.Windows.Forms.ComboBox();
			this.selectBtn = new System.Windows.Forms.Button();
			this.addBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.clearBtn = new System.Windows.Forms.Button();
			this.foodCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.foodListBox = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Britannic Bold", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(33, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(413, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "SIMPLE FAVORITE FOOD PICKER APP";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cuisine";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(228, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Food List";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(463, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(185, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "My Favorite Food List";
			// 
			// foodComboBox
			// 
			this.foodComboBox.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.foodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.foodComboBox.FormattingEnabled = true;
			this.foodComboBox.Location = new System.Drawing.Point(37, 132);
			this.foodComboBox.Name = "foodComboBox";
			this.foodComboBox.Size = new System.Drawing.Size(142, 23);
			this.foodComboBox.TabIndex = 4;
			this.foodComboBox.Text = "Filipino";
			// 
			// selectBtn
			// 
			this.selectBtn.BackColor = System.Drawing.Color.SandyBrown;
			this.selectBtn.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectBtn.ForeColor = System.Drawing.Color.Black;
			this.selectBtn.Location = new System.Drawing.Point(37, 171);
			this.selectBtn.Name = "selectBtn";
			this.selectBtn.Size = new System.Drawing.Size(142, 29);
			this.selectBtn.TabIndex = 5;
			this.selectBtn.Text = "Select";
			this.selectBtn.UseVisualStyleBackColor = false;
			this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
			// 
			// addBtn
			// 
			this.addBtn.BackColor = System.Drawing.Color.SandyBrown;
			this.addBtn.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addBtn.Location = new System.Drawing.Point(232, 331);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(172, 31);
			this.addBtn.TabIndex = 6;
			this.addBtn.Text = "Add";
			this.addBtn.UseVisualStyleBackColor = false;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.BackColor = System.Drawing.Color.SandyBrown;
			this.deleteBtn.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteBtn.Location = new System.Drawing.Point(723, 149);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(103, 33);
			this.deleteBtn.TabIndex = 7;
			this.deleteBtn.Text = "Remove";
			this.deleteBtn.UseVisualStyleBackColor = false;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// clearBtn
			// 
			this.clearBtn.BackColor = System.Drawing.Color.SandyBrown;
			this.clearBtn.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearBtn.Location = new System.Drawing.Point(723, 188);
			this.clearBtn.Name = "clearBtn";
			this.clearBtn.Size = new System.Drawing.Size(103, 31);
			this.clearBtn.TabIndex = 8;
			this.clearBtn.Text = "Clear All";
			this.clearBtn.UseVisualStyleBackColor = false;
			this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
			// 
			// foodCheckedListBox
			// 
			this.foodCheckedListBox.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.foodCheckedListBox.FormattingEnabled = true;
			this.foodCheckedListBox.Location = new System.Drawing.Point(232, 132);
			this.foodCheckedListBox.Name = "foodCheckedListBox";
			this.foodCheckedListBox.Size = new System.Drawing.Size(172, 184);
			this.foodCheckedListBox.TabIndex = 9;
			// 
			// foodListBox
			// 
			this.foodListBox.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.foodListBox.FormattingEnabled = true;
			this.foodListBox.Location = new System.Drawing.Point(467, 132);
			this.foodListBox.Name = "foodListBox";
			this.foodListBox.Size = new System.Drawing.Size(223, 121);
			this.foodListBox.TabIndex = 10;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SandyBrown;
			this.panel1.Location = new System.Drawing.Point(200, 96);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(10, 277);
			this.panel1.TabIndex = 11;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.SandyBrown;
			this.panel2.Location = new System.Drawing.Point(431, 96);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(10, 278);
			this.panel2.TabIndex = 12;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(861, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.foodListBox);
			this.Controls.Add(this.foodCheckedListBox);
			this.Controls.Add(this.clearBtn);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.selectBtn);
			this.Controls.Add(this.foodComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox foodComboBox;
		private System.Windows.Forms.Button selectBtn;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button clearBtn;
		private System.Windows.Forms.CheckedListBox foodCheckedListBox;
		private System.Windows.Forms.ListBox foodListBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}


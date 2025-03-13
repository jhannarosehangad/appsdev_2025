namespace SimpleFormsAppWithCheckedListBox
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
			this.movieCheckListBox = new System.Windows.Forms.CheckedListBox();
			this.movieListBox = new System.Windows.Forms.ListBox();
			this.addBtn = new System.Windows.Forms.Button();
			this.removeBtn = new System.Windows.Forms.Button();
			this.clearBtn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Britannic Bold", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(42, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(421, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "SIMPLE FAVORITE MOVIE PICKER APP";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(44, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(158, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Movies/Series List";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(317, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(237, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "My Programming Languages";
			// 
			// movieCheckListBox
			// 
			this.movieCheckListBox.FormattingEnabled = true;
			this.movieCheckListBox.Location = new System.Drawing.Point(47, 140);
			this.movieCheckListBox.Name = "movieCheckListBox";
			this.movieCheckListBox.Size = new System.Drawing.Size(197, 214);
			this.movieCheckListBox.TabIndex = 3;
			this.movieCheckListBox.SelectedIndexChanged += new System.EventHandler(this.movieCheckListBox_SelectedIndexChanged);
			// 
			// movieListBox
			// 
			this.movieListBox.FormattingEnabled = true;
			this.movieListBox.Location = new System.Drawing.Point(320, 140);
			this.movieListBox.Name = "movieListBox";
			this.movieListBox.Size = new System.Drawing.Size(280, 134);
			this.movieListBox.TabIndex = 4;
			// 
			// addBtn
			// 
			this.addBtn.BackColor = System.Drawing.Color.Transparent;
			this.addBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBtn.BackgroundImage")));
			this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addBtn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addBtn.ForeColor = System.Drawing.Color.Transparent;
			this.addBtn.Location = new System.Drawing.Point(79, 372);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(132, 35);
			this.addBtn.TabIndex = 5;
			this.addBtn.Text = "Add";
			this.addBtn.UseVisualStyleBackColor = false;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// removeBtn
			// 
			this.removeBtn.BackColor = System.Drawing.Color.Transparent;
			this.removeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeBtn.BackgroundImage")));
			this.removeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.removeBtn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.removeBtn.ForeColor = System.Drawing.Color.Transparent;
			this.removeBtn.Location = new System.Drawing.Point(635, 167);
			this.removeBtn.Name = "removeBtn";
			this.removeBtn.Size = new System.Drawing.Size(127, 35);
			this.removeBtn.TabIndex = 6;
			this.removeBtn.Text = "Remove";
			this.removeBtn.UseVisualStyleBackColor = false;
			this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
			// 
			// clearBtn
			// 
			this.clearBtn.BackColor = System.Drawing.Color.Transparent;
			this.clearBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearBtn.BackgroundImage")));
			this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearBtn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearBtn.ForeColor = System.Drawing.Color.Transparent;
			this.clearBtn.Location = new System.Drawing.Point(635, 216);
			this.clearBtn.Name = "clearBtn";
			this.clearBtn.Size = new System.Drawing.Size(127, 34);
			this.clearBtn.TabIndex = 7;
			this.clearBtn.Text = "Clear All";
			this.clearBtn.UseVisualStyleBackColor = false;
			this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.ForeColor = System.Drawing.Color.Transparent;
			this.panel1.Location = new System.Drawing.Point(276, 104);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(10, 303);
			this.panel1.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.clearBtn);
			this.Controls.Add(this.removeBtn);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.movieListBox);
			this.Controls.Add(this.movieCheckListBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckedListBox movieCheckListBox;
		private System.Windows.Forms.ListBox movieListBox;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.Button removeBtn;
		private System.Windows.Forms.Button clearBtn;
		private System.Windows.Forms.Panel panel1;
	}
}


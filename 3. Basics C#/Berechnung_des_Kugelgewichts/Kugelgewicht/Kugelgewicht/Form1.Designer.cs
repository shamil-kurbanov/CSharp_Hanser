namespace Kugelgewicht
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			groupBox1 = new GroupBox();
			textBox = new TextBox();
			label_diameter = new Label();
			label_title = new Label();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			rb_holz = new RadioButton();
			rb_alu = new RadioButton();
			rb_glas = new RadioButton();
			rb_eisen = new RadioButton();
			rb_blei = new RadioButton();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(rb_blei);
			groupBox1.Controls.Add(rb_eisen);
			groupBox1.Controls.Add(rb_glas);
			groupBox1.Controls.Add(rb_alu);
			groupBox1.Controls.Add(rb_holz);
			groupBox1.Location = new Point(39, 144);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(188, 233);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Material";
			// 
			// textBox
			// 
			textBox.Location = new Point(43, 85);
			textBox.Name = "textBox";
			textBox.Size = new Size(184, 27);
			textBox.TabIndex = 1;
			// 
			// label_diameter
			// 
			label_diameter.AutoSize = true;
			label_diameter.Location = new Point(43, 47);
			label_diameter.Name = "label_diameter";
			label_diameter.Size = new Size(105, 20);
			label_diameter.TabIndex = 2;
			label_diameter.Text = "Diameter (cm)";
			// 
			// label_title
			// 
			label_title.AutoSize = true;
			label_title.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label_title.Location = new Point(263, 32);
			label_title.Name = "label_title";
			label_title.Size = new Size(381, 29);
			label_title.TabIndex = 3;
			label_title.Text = "Berechnung des Kugelgewichts";
			// 
			// button1
			// 
			button1.Location = new Point(278, 132);
			button1.Name = "button1";
			button1.Size = new Size(306, 50);
			button1.TabIndex = 4;
			button1.Text = "Methode mit Rückgabewert";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(278, 221);
			button2.Name = "button2";
			button2.Size = new Size(306, 50);
			button2.TabIndex = 5;
			button2.Text = "Methode ohne Rückgabewert";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(278, 307);
			button3.Name = "button3";
			button3.Size = new Size(306, 50);
			button3.TabIndex = 6;
			button3.Text = "Methode mit ref-Parameter";
			button3.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(611, 147);
			label1.Name = "label1";
			label1.Size = new Size(50, 20);
			label1.TabIndex = 7;
			label1.Text = "label1";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(611, 236);
			label2.Name = "label2";
			label2.Size = new Size(50, 20);
			label2.TabIndex = 8;
			label2.Text = "label2";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(611, 322);
			label3.Name = "label3";
			label3.Size = new Size(50, 20);
			label3.TabIndex = 9;
			label3.Text = "label3";
			// 
			// rb_holz
			// 
			rb_holz.AutoSize = true;
			rb_holz.Location = new Point(41, 39);
			rb_holz.Name = "rb_holz";
			rb_holz.Size = new Size(61, 24);
			rb_holz.TabIndex = 0;
			rb_holz.TabStop = true;
			rb_holz.Text = "Holz";
			rb_holz.UseVisualStyleBackColor = true;
			// 
			// rb_alu
			// 
			rb_alu.AutoSize = true;
			rb_alu.Location = new Point(41, 81);
			rb_alu.Name = "rb_alu";
			rb_alu.Size = new Size(102, 24);
			rb_alu.TabIndex = 1;
			rb_alu.TabStop = true;
			rb_alu.Text = "Aluminium";
			rb_alu.UseVisualStyleBackColor = true;
			// 
			// rb_glas
			// 
			rb_glas.AutoSize = true;
			rb_glas.Location = new Point(41, 122);
			rb_glas.Name = "rb_glas";
			rb_glas.Size = new Size(58, 24);
			rb_glas.TabIndex = 2;
			rb_glas.TabStop = true;
			rb_glas.Text = "Glas";
			rb_glas.UseVisualStyleBackColor = true;
			// 
			// rb_eisen
			// 
			rb_eisen.AutoSize = true;
			rb_eisen.Location = new Point(41, 165);
			rb_eisen.Name = "rb_eisen";
			rb_eisen.Size = new Size(64, 24);
			rb_eisen.TabIndex = 3;
			rb_eisen.TabStop = true;
			rb_eisen.Text = "Eisen";
			rb_eisen.UseVisualStyleBackColor = true;
			// 
			// rb_blei
			// 
			rb_blei.AutoSize = true;
			rb_blei.Location = new Point(41, 202);
			rb_blei.Name = "rb_blei";
			rb_blei.Size = new Size(55, 24);
			rb_blei.TabIndex = 4;
			rb_blei.TabStop = true;
			rb_blei.Text = "Blei";
			rb_blei.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label_title);
			Controls.Add(label_diameter);
			Controls.Add(textBox);
			Controls.Add(groupBox1);
			Name = "Form1";
			Text = "Form1";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox1;
		private TextBox textBox;
		private Label label_diameter;
		private Label label_title;
		private Button button1;
		private Button button2;
		private Button button3;
		private Label label1;
		private Label label2;
		private Label label3;
		private RadioButton rb_blei;
		private RadioButton rb_eisen;
		private RadioButton rb_glas;
		private RadioButton rb_alu;
		private RadioButton rb_holz;
	}
}
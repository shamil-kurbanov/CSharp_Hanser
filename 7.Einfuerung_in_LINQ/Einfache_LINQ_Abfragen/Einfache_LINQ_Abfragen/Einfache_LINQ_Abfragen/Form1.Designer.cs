namespace Einfache_LINQ_Abfragen
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
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			listBox1 = new ListBox();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(261, 51);
			button1.Name = "button1";
			button1.Size = new Size(248, 68);
			button1.TabIndex = 0;
			button1.Text = "Abfrage mit Query Expression Syntax";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(261, 143);
			button2.Name = "button2";
			button2.Size = new Size(248, 68);
			button2.TabIndex = 1;
			button2.Text = "Abfrage mit Extension Method Syntax";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(261, 236);
			button3.Name = "button3";
			button3.Size = new Size(248, 68);
			button3.TabIndex = 2;
			button3.Text = "Gemischte Syntax";
			button3.UseVisualStyleBackColor = true;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.Location = new Point(12, 51);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(148, 264);
			listBox1.TabIndex = 3;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(576, 450);
			Controls.Add(listBox1);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button button1;
		private Button button2;
		private Button button3;
		private ListBox listBox1;
	}
}

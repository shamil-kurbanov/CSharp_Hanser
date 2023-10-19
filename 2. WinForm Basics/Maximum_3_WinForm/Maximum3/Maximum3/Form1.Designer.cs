namespace Maximum3
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
			textBox_a = new TextBox();
			textBox_b = new TextBox();
			textBox_c = new TextBox();
			button1 = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label_result = new Label();
			SuspendLayout();
			// 
			// textBox_a
			// 
			textBox_a.Location = new Point(38, 141);
			textBox_a.Name = "textBox_a";
			textBox_a.Size = new Size(186, 27);
			textBox_a.TabIndex = 0;
			// 
			// textBox_b
			// 
			textBox_b.Location = new Point(299, 141);
			textBox_b.Name = "textBox_b";
			textBox_b.Size = new Size(186, 27);
			textBox_b.TabIndex = 1;
			// 
			// textBox_c
			// 
			textBox_c.Location = new Point(544, 141);
			textBox_c.Name = "textBox_c";
			textBox_c.Size = new Size(186, 27);
			textBox_c.TabIndex = 2;
			// 
			// button1
			// 
			button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(254, 211);
			button1.Name = "button1";
			button1.Size = new Size(276, 52);
			button1.TabIndex = 3;
			button1.Text = "Maximum";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(105, 96);
			label1.Name = "label1";
			label1.Size = new Size(24, 25);
			label1.TabIndex = 4;
			label1.Text = "a";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(383, 96);
			label2.Name = "label2";
			label2.Size = new Size(24, 25);
			label2.TabIndex = 5;
			label2.Text = "b";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(623, 96);
			label3.Name = "label3";
			label3.Size = new Size(23, 25);
			label3.TabIndex = 6;
			label3.Text = "c";
			// 
			// label_result
			// 
			label_result.AutoSize = true;
			label_result.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label_result.Location = new Point(254, 302);
			label_result.Name = "label_result";
			label_result.Size = new Size(101, 29);
			label_result.TabIndex = 7;
			label_result.Text = "Result: ";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(779, 450);
			Controls.Add(label_result);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(textBox_c);
			Controls.Add(textBox_b);
			Controls.Add(textBox_a);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox_a;
		private TextBox textBox_b;
		private TextBox textBox_c;
		private Button button1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label_result;
	}
}
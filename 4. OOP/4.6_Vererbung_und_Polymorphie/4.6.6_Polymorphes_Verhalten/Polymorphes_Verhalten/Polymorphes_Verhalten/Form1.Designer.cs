namespace Polymorphes_Verhalten
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 40);
            label1.Name = "label1";
            label1.Size = new Size(93, 17);
            label1.TabIndex = 0;
            label1.Text = "Kundenbouns";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(315, 40);
            label2.Name = "label2";
            label2.Size = new Size(137, 17);
            label2.TabIndex = 1;
            label2.Text = "Brutto-Warenwert (€)";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(25, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 265);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 28);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(352, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(315, 219);
            button1.Name = "button1";
            button1.Size = new Size(164, 46);
            button1.TabIndex = 4;
            button1.Text = "Einkaufen (for-Schleife)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(315, 288);
            button2.Name = "button2";
            button2.Size = new Size(164, 46);
            button2.TabIndex = 5;
            button2.Text = "Einkaufen (foreach-Schleife)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 364);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}
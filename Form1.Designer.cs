
namespace triangles
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_a = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.atextBox = new System.Windows.Forms.TextBox();
            this.btextBox = new System.Windows.Forms.TextBox();
            this.label_b = new System.Windows.Forms.Label();
            this.ctextBox = new System.Windows.Forms.TextBox();
            this.label_c = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.import_Button = new System.Windows.Forms.Button();
            this.export_button = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 600);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_a.Location = new System.Drawing.Point(138, 639);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(19, 20);
            this.label_a.TabIndex = 1;
            this.label_a.Text = "a";
            // 
            // drawButton
            // 
            this.drawButton.BackColor = System.Drawing.Color.Yellow;
            this.drawButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.drawButton.FlatAppearance.BorderSize = 0;
            this.drawButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.drawButton.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawButton.Location = new System.Drawing.Point(12, 671);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(632, 45);
            this.drawButton.TabIndex = 2;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = false;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // atextBox
            // 
            this.atextBox.Location = new System.Drawing.Point(162, 639);
            this.atextBox.MaxLength = 500;
            this.atextBox.Name = "atextBox";
            this.atextBox.Size = new System.Drawing.Size(67, 22);
            this.atextBox.TabIndex = 3;
            this.atextBox.Text = "0\r\n";
            this.atextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btextBox
            // 
            this.btextBox.Location = new System.Drawing.Point(296, 639);
            this.btextBox.MaxLength = 500;
            this.btextBox.Name = "btextBox";
            this.btextBox.Size = new System.Drawing.Size(67, 22);
            this.btextBox.TabIndex = 5;
            this.btextBox.Text = "0";
            this.btextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_b.Location = new System.Drawing.Point(273, 639);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(19, 20);
            this.label_b.TabIndex = 4;
            this.label_b.Text = "b";
            // 
            // ctextBox
            // 
            this.ctextBox.Location = new System.Drawing.Point(434, 638);
            this.ctextBox.MaxLength = 500;
            this.ctextBox.Name = "ctextBox";
            this.ctextBox.Size = new System.Drawing.Size(67, 22);
            this.ctextBox.TabIndex = 7;
            this.ctextBox.Text = "0";
            this.ctextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_c.Location = new System.Drawing.Point(412, 638);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(19, 20);
            this.label_c.TabIndex = 6;
            this.label_c.Text = "c";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(12, 722);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(632, 33);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete selected triangle";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // import_Button
            // 
            this.import_Button.BackColor = System.Drawing.Color.GreenYellow;
            this.import_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.import_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import_Button.Location = new System.Drawing.Point(666, 715);
            this.import_Button.Name = "import_Button";
            this.import_Button.Size = new System.Drawing.Size(273, 40);
            this.import_Button.TabIndex = 9;
            this.import_Button.Text = "Import triangles";
            this.import_Button.UseVisualStyleBackColor = false;
            this.import_Button.Click += new System.EventHandler(this.import_Button_Click);
            // 
            // export_button
            // 
            this.export_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.export_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.export_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_button.Location = new System.Drawing.Point(666, 671);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(273, 45);
            this.export_button.TabIndex = 10;
            this.export_button.Text = "Export triangles";
            this.export_button.UseVisualStyleBackColor = false;
            this.export_button.Click += new System.EventHandler(this.export_button_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox.Font = new System.Drawing.Font("Verdana Pro Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(666, 9);
            this.listBox.Margin = new System.Windows.Forms.Padding(10);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(273, 664);
            this.listBox.TabIndex = 11;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 612);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Please insert triangle sides or select triangles from list and click Draw";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(951, 764);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.export_button);
            this.Controls.Add(this.import_Button);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.ctextBox);
            this.Controls.Add(this.label_c);
            this.Controls.Add(this.btextBox);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.atextBox);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.TextBox atextBox;
        private System.Windows.Forms.TextBox btextBox;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.TextBox ctextBox;
        private System.Windows.Forms.Label label_c;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button import_Button;
        private System.Windows.Forms.Button export_button;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
    }
}


namespace WinFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboxbevarages = new System.Windows.Forms.ComboBox();
            this.savebutton2 = new System.Windows.Forms.Button();
            this.comboxfood = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(248, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select the Order ...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(248, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Food : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(214, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Bevarages : ";
            // 
            // comboxbevarages
            // 
            this.comboxbevarages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxbevarages.FormattingEnabled = true;
            this.comboxbevarages.Location = new System.Drawing.Point(364, 229);
            this.comboxbevarages.Name = "comboxbevarages";
            this.comboxbevarages.Size = new System.Drawing.Size(151, 28);
            this.comboxbevarages.TabIndex = 4;
            this.comboxbevarages.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // savebutton2
            // 
            this.savebutton2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savebutton2.ForeColor = System.Drawing.Color.DarkRed;
            this.savebutton2.Location = new System.Drawing.Point(603, 360);
            this.savebutton2.Name = "savebutton2";
            this.savebutton2.Size = new System.Drawing.Size(94, 29);
            this.savebutton2.TabIndex = 9;
            this.savebutton2.Text = "Save";
            this.savebutton2.UseVisualStyleBackColor = true;
            this.savebutton2.Click += new System.EventHandler(this.savebutton2_Click);
            // 
            // comboxfood
            // 
            this.comboxfood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxfood.FormattingEnabled = true;
            this.comboxfood.Location = new System.Drawing.Point(364, 160);
            this.comboxfood.Name = "comboxfood";
            this.comboxfood.Size = new System.Drawing.Size(151, 28);
            this.comboxfood.TabIndex = 10;
            this.comboxfood.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(603, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboxfood);
            this.Controls.Add(this.savebutton2);
            this.Controls.Add(this.comboxbevarages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboxbevarages;
        private Button savebutton2;
        private ComboBox comboxfood;
        private Button button1;
    }
}
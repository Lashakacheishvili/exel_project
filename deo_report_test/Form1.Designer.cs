namespace deo_report_test
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
            this.qalaqi = new System.Windows.Forms.ComboBox();
            this.raioni = new System.Windows.Forms.ComboBox();
            this.municipaliteti = new System.Windows.Forms.ComboBox();
            this.daba = new System.Windows.Forms.ComboBox();
            this.sofeli = new System.Windows.Forms.ComboBox();
            this.dasaxeleba = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qalaqi
            // 
            this.qalaqi.FormattingEnabled = true;
            this.qalaqi.Location = new System.Drawing.Point(281, 37);
            this.qalaqi.Name = "qalaqi";
            this.qalaqi.Size = new System.Drawing.Size(121, 21);
            this.qalaqi.TabIndex = 0;
            // 
            // raioni
            // 
            this.raioni.FormattingEnabled = true;
            this.raioni.Location = new System.Drawing.Point(408, 37);
            this.raioni.Name = "raioni";
            this.raioni.Size = new System.Drawing.Size(121, 21);
            this.raioni.TabIndex = 1;
            // 
            // municipaliteti
            // 
            this.municipaliteti.FormattingEnabled = true;
            this.municipaliteti.Location = new System.Drawing.Point(535, 37);
            this.municipaliteti.Name = "municipaliteti";
            this.municipaliteti.Size = new System.Drawing.Size(121, 21);
            this.municipaliteti.TabIndex = 2;
            // 
            // daba
            // 
            this.daba.FormattingEnabled = true;
            this.daba.Location = new System.Drawing.Point(662, 37);
            this.daba.Name = "daba";
            this.daba.Size = new System.Drawing.Size(121, 21);
            this.daba.TabIndex = 3;
            // 
            // sofeli
            // 
            this.sofeli.FormattingEnabled = true;
            this.sofeli.Location = new System.Drawing.Point(789, 37);
            this.sofeli.Name = "sofeli";
            this.sofeli.Size = new System.Drawing.Size(121, 21);
            this.sofeli.TabIndex = 4;
            // 
            // dasaxeleba
            // 
            this.dasaxeleba.Location = new System.Drawing.Point(3, 12);
            this.dasaxeleba.Multiline = true;
            this.dasaxeleba.Name = "dasaxeleba";
            this.dasaxeleba.Size = new System.Drawing.Size(272, 156);
            this.dasaxeleba.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dasaxeleba);
            this.Controls.Add(this.sofeli);
            this.Controls.Add(this.daba);
            this.Controls.Add(this.municipaliteti);
            this.Controls.Add(this.raioni);
            this.Controls.Add(this.qalaqi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox qalaqi;
        private System.Windows.Forms.ComboBox raioni;
        private System.Windows.Forms.ComboBox municipaliteti;
        private System.Windows.Forms.ComboBox daba;
        private System.Windows.Forms.ComboBox sofeli;
        private System.Windows.Forms.TextBox dasaxeleba;
        private System.Windows.Forms.Button button1;
    }
}


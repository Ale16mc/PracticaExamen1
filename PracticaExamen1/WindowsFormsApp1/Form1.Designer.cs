namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLado1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFiguras = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLado2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLado3 = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Practica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbLado1
            // 
            this.tbLado1.Location = new System.Drawing.Point(83, 80);
            this.tbLado1.Name = "tbLado1";
            this.tbLado1.Size = new System.Drawing.Size(100, 20);
            this.tbLado1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Elija figura";
            // 
            // cbFiguras
            // 
            this.cbFiguras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiguras.FormattingEnabled = true;
            this.cbFiguras.Items.AddRange(new object[] {
            "Triangulo",
            "Rectángulo",
            "Rombo"});
            this.cbFiguras.Location = new System.Drawing.Point(83, 43);
            this.cbFiguras.Name = "cbFiguras";
            this.cbFiguras.Size = new System.Drawing.Size(139, 21);
            this.cbFiguras.TabIndex = 4;
            this.cbFiguras.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lado 2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbLado2
            // 
            this.tbLado2.Location = new System.Drawing.Point(83, 117);
            this.tbLado2.Name = "tbLado2";
            this.tbLado2.Size = new System.Drawing.Size(100, 20);
            this.tbLado2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lado 3";
            // 
            // tbLado3
            // 
            this.tbLado3.Location = new System.Drawing.Point(83, 158);
            this.tbLado3.Name = "tbLado3";
            this.tbLado3.Size = new System.Drawing.Size(100, 20);
            this.tbLado3.TabIndex = 8;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(93, 202);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 9;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Resultado";
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(83, 252);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.Size = new System.Drawing.Size(100, 20);
            this.tbResultado.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 284);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.tbLado3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLado2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFiguras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLado1);
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
        private System.Windows.Forms.TextBox tbLado1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFiguras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLado2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLado3;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbResultado;
    }
}


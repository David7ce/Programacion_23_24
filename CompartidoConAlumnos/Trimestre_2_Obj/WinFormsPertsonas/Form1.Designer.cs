namespace WinFormsPersonas
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
            tbNombre = new TextBox();
            tbEdad = new TextBox();
            tbDNI = new TextBox();
            tbLetraDNI = new TextBox();
            lblNombre = new Label();
            label2 = new Label();
            label3 = new Label();
            tbArea = new TextBox();
            btnAltas = new Button();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(80, 6);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(173, 23);
            tbNombre.TabIndex = 0;
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(331, 9);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(100, 23);
            tbEdad.TabIndex = 1;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(80, 35);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(120, 23);
            tbDNI.TabIndex = 2;
            // 
            // tbLetraDNI
            // 
            tbLetraDNI.Location = new Point(206, 35);
            tbLetraDNI.MaxLength = 1;
            tbLetraDNI.Name = "tbLetraDNI";
            tbLetraDNI.Size = new Size(26, 23);
            tbLetraDNI.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(23, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 10);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 5;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 38);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 6;
            label3.Text = "DNI";
            // 
            // tbArea
            // 
            tbArea.Location = new Point(23, 122);
            tbArea.Multiline = true;
            tbArea.Name = "tbArea";
            tbArea.ScrollBars = ScrollBars.Vertical;
            tbArea.Size = new Size(467, 86);
            tbArea.TabIndex = 7;
            // 
            // btnAltas
            // 
            btnAltas.Location = new Point(78, 78);
            btnAltas.Name = "btnAltas";
            btnAltas.Size = new Size(122, 23);
            btnAltas.TabIndex = 8;
            btnAltas.Text = "Nueva Persona";
            btnAltas.UseVisualStyleBackColor = true;
            btnAltas.Click += Altas_Persona;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 229);
            Controls.Add(btnAltas);
            Controls.Add(tbArea);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNombre);
            Controls.Add(tbLetraDNI);
            Controls.Add(tbDNI);
            Controls.Add(tbEdad);
            Controls.Add(tbNombre);
            Name = "Form1";
            Text = "Ficha Personas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNombre;
        private TextBox tbEdad;
        private TextBox tbDNI;
        private TextBox tbLetraDNI;
        private Label lblNombre;
        private Label label2;
        private Label label3;
        private TextBox tbArea;
        private Button btnAltas;
    }
}

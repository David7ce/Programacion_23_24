namespace WinFormPersona;

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
        label1 = new Label();
        label2 = new Label();
        tbEdad = new TextBox();
        label3 = new Label();
        tbDni = new TextBox();
        tbLetraDni = new TextBox();
        btnNuevaPersona = new Button();
        tbArea = new TextBox();
        SuspendLayout();
        // 
        // tbNombre
        // 
        tbNombre.Location = new Point(69, 12);
        tbNombre.Name = "tbNombre";
        tbNombre.Size = new Size(174, 23);
        tbNombre.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 15);
        label1.Name = "label1";
        label1.Size = new Size(51, 15);
        label1.TabIndex = 1;
        label1.Text = "Nombre";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(269, 15);
        label2.Name = "label2";
        label2.Size = new Size(33, 15);
        label2.TabIndex = 2;
        label2.Text = "Edad";
        // 
        // tbEdad
        // 
        tbEdad.Location = new Point(308, 12);
        tbEdad.Name = "tbEdad";
        tbEdad.Size = new Size(100, 23);
        tbEdad.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(38, 52);
        label3.Name = "label3";
        label3.Size = new Size(25, 15);
        label3.TabIndex = 4;
        label3.Text = "Dni";
        // 
        // tbDni
        // 
        tbDni.Location = new Point(69, 49);
        tbDni.Name = "tbDni";
        tbDni.Size = new Size(100, 23);
        tbDni.TabIndex = 5;
        // 
        // tbLetraDni
        // 
        tbLetraDni.Location = new Point(175, 49);
        tbLetraDni.MaxLength = 1;
        tbLetraDni.Name = "tbLetraDni";
        tbLetraDni.Size = new Size(20, 23);
        tbLetraDni.TabIndex = 6;
        // 
        // btnNuevaPersona
        // 
        btnNuevaPersona.Location = new Point(257, 48);
        btnNuevaPersona.Name = "btnNuevaPersona";
        btnNuevaPersona.Size = new Size(107, 23);
        btnNuevaPersona.TabIndex = 7;
        btnNuevaPersona.Text = "Añadir Persona";
        btnNuevaPersona.UseVisualStyleBackColor = true;
        btnNuevaPersona.Click += btnNuevaPersona_Click;
        // 
        // tbArea
        // 
        tbArea.Location = new Point(12, 89);
        tbArea.Multiline = true;
        tbArea.Name = "tbArea";
        tbArea.ReadOnly = true;
        tbArea.Size = new Size(396, 140);
        tbArea.TabIndex = 8;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(422, 241);
        Controls.Add(tbArea);
        Controls.Add(btnNuevaPersona);
        Controls.Add(tbLetraDni);
        Controls.Add(tbDni);
        Controls.Add(label3);
        Controls.Add(tbEdad);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(tbNombre);
        Name = "Form1";
        Text = "Ficha de datos persona";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox tbNombre;
    private Label label1;
    private Label label2;
    private TextBox tbEdad;
    private Label label3;
    private TextBox tbDni;
    private TextBox tbLetraDni;
    private Button btnNuevaPersona;
    private TextBox tbArea;

}
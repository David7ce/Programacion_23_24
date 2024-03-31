namespace WinFormsPersonas;

using Personas;
using MisContenedores;
public partial class Form1 : Form
{
    //    private List<Persona> socios;
    MiLista socios;
    public Form1()
    {
        InitializeComponent();
        //socios = new List<Persona>();
        socios = new MiLista();
    }

    private void Altas_Persona(object sender, EventArgs e)
    {
        if (!String.IsNullOrWhiteSpace(tbNombre.Text) &
            !String.IsNullOrWhiteSpace(tbEdad.Text) &
            !String.IsNullOrWhiteSpace(tbDNI.Text) &
            !String.IsNullOrWhiteSpace(tbLetraDNI.Text)
            )
        {
            Persona nueva = new Persona(Convert.ToInt32(tbDNI.Text), tbLetraDNI.Text[0]);
            nueva.Edad = Convert.ToInt32(tbEdad.Text);
            nueva.Nombre = tbNombre.Text;
            socios.Add(nueva);
            tbArea.Text = socios.ToString();
        }
    }
}
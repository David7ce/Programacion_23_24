namespace WinFormPersona;

using WinFormPersona.Modelo;

public partial class Form1 : Form
{
    MiLista listaPersonas;
    public Form1()
    {
        listaPersonas = new MiLista();
        InitializeComponent();
    }

    private void btnNuevaPersona_Click(object sender, EventArgs e)
    {
        if (!(String.IsNullOrWhiteSpace(tbNombre.Text) ||
            String.IsNullOrWhiteSpace(tbEdad.Text) ||
            String.IsNullOrWhiteSpace(tbDni.Text) ||
            String.IsNullOrWhiteSpace(tbLetraDni.Text)
            ))
        {
            Persona p = new Persona(Convert.ToInt32(tbDni.Text), tbLetraDni.Text[0]);
            p.Edad = Convert.ToInt32(tbEdad.Text);
            p.Nombre = tbNombre.Text;
            listaPersonas.Add(p);
            tbArea.Text = listaPersonas.ToString();
        }
    }
}
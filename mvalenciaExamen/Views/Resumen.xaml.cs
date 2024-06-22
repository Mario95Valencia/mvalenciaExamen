namespace mvalenciaExamen.Views;

public partial class Resumen : ContentPage
{
    public Resumen()
    {
        InitializeComponent();
    }
    public Resumen(string nombre, string apellido, string edad, string fecha, string ciudad, string pais, string monto, string mensual, string total,string usu)
    {
        InitializeComponent();
        txt_nombre.Text = nombre;
        txt_apellido.Text = apellido;  
        txt_edad.Text = edad;  
        txt_fecha.Text = fecha;
        txt_ciudad.Text = ciudad;
        txt_pais.Text = pais;   
        txt_monto.Text = monto;
        txt_mensualidad.Text = mensual;
        txt_total.Text = total;
        lbl_nombre.Text = usu;
    }
}
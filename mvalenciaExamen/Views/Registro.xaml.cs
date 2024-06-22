namespace mvalenciaExamen.Views;

public partial class Registro : ContentPage
{
    double total;
    public Registro()
    {
        InitializeComponent();
    }
    public Registro(string usuario)
    {
        InitializeComponent();
        lbl_nombre.Text = "Usuario conectado: " + usuario;
    }

    private void btn_calculo_Clicked(object sender, EventArgs e)
    {
        double cuotaInicial = Convert.ToDouble(txt_cuota.Text);
        if (cuotaInicial > 1500)
        {
            DisplayAlert("Mensaje", "La cuota inicial no puede superar al valor del curso", "OK");
            return;
        }
        double saldo = 1500 - cuotaInicial;
        double mensualidades = (saldo / 4) + (0.04 * 1500);
        txt_mensualidad.Text = mensualidades.ToString();
        total = (mensualidades * 4) + cuotaInicial;

    }

    private void btn_resumen_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Resumen(txt_nombre.Text,txt_apellido.Text,txt_edad.Text,dtp_fecha.Date.ToString(),cmb_ciudades.SelectedItem.ToString(),cmb_paises.SelectedItem.ToString(),txt_cuota.Text,txt_mensualidad.Text,total.ToString(),lbl_nombre.Text));
    }
}
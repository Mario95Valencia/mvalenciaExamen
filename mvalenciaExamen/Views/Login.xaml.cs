using Microsoft.Win32;

namespace mvalenciaExamen.Views;

public partial class Login : ContentPage
{
    string[,] usuarios = new string[2, 2];
    public Login()
    {
        InitializeComponent();
    }

    private void btn_inicio_Clicked(object sender, EventArgs e)
    {
        usuarios[0, 0] = "estudiante";
        usuarios[0, 1] = "moviles";
        usuarios[1, 0] = "uisrael ";
        usuarios[1, 1] = "2024";

        for (int i = 0; i < 2; i++)
        {
            if (usuarios[i, 0] == txt_usuario.Text)
            {
                if (usuarios[i, 1] == txt_contrasena.Text)
                {
                    Navigation.PushAsync(new Registro(usuarios[i, 0]));
                    break;
                }
            }
        }
    }
}
namespace machuquinTS2.Vistas;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        String usuario = "uisrael";
        string contrase�a = "1234";
        if (usuario == txtUsuario.Text && contrase�a == txtContrase�a.Text)
        {
            Navigation.PushAsync(new vElementos());

        }
        else
        {
            DisplayAlert("Alerta", "usuario/contrase�a incorrectos", "Cerrar");
            txtUsuario.Text = "";
            txtContrase�a.Text = "";
        }
    }
}
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void ValidarContraseñas(object? sender, EventArgs e)
	{
		// Mensaje de error para contraseñas inválidas
		string errorMessage = """
				Revisa el formato de tu contraseña . Debe seguir este formato:
				- Al menos una letra mayúscula
				- Al menos una letra minúscula
				- Al menos un símbolo
				- Al menos un número
				""";
			
				
		// Validar nulos en ambos campos de texto
		if (Contra1.Text == null || Contra2.Text == null)
			await DisplayAlert("❌", "Alguno de los campos esta vacio", "Entendido");

		else
		{
			// Obtener los valores de los campos de texto
			String password1 = Contra1.Text;
			String password2 = Contra2.Text;

			// Expresión regular para validar la contraseña
			// test expression: Mmv1$
			string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$";

			// Validacion de ambas contraseñas
			if (Regex.IsMatch(password1, pattern) && Regex.IsMatch(password2, pattern))
				if (password1 != password2)
					await DisplayAlert(
						"❌",
						"Las contraseñas no coinciden",
						"Entendido"
					);
				else
					await DisplayAlert(
						"✅",
						"Las contraseñas coinciden y son validas",
						"Entendido"
					);

			// Validacion individual de cada campo para mejorar el UX
			else if (!Regex.IsMatch(password1, pattern))
				await DisplayAlert(
					"❌ Contraseña 1 Inválida",
					errorMessage,
					"Entendido"
				);
			else if (!Regex.IsMatch(password2, pattern))
				await DisplayAlert(
					"❌ Contraseña 2 Inválida",
					errorMessage,
					"Entendido"
				);
			else
				await DisplayAlert(
					"❌",
					errorMessage,
					"Entendido"
				);

		}

	}

}

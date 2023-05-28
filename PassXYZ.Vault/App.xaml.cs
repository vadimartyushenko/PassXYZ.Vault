using System.Diagnostics;

namespace PassXYZ.Vault;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
		var window = base.CreateWindow(activationState);
        var nameApp = "PassXYZ.Vault.App";
        window.Created += (s , e) => {
            Debug.WriteLine($"{nameApp}: 1. Created event");
        };
        window.Activated += (s, e) => {
            Debug.WriteLine($"{nameApp}: 2. Activated event");
        };
        window.Deactivated += (s, e) => {
            Debug.WriteLine($"{nameApp}: 3. Created event");
        };
        window.Stopped += (s, e) => {
            Debug.WriteLine($"{nameApp}: 4. Stopped event");
        };
        window.Resumed += (s, e) => {
            Debug.WriteLine($"{nameApp}: 5. Resumed event");
        };
        window.Destroying += (s, e) => {
            Debug.WriteLine($"{nameApp}: 6. Destroying event");
        };
        return window;
    }
}

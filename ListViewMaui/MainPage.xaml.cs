namespace ListViewMaui;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
        this.SizeChanged += MainPage_SizeChanged;
    }

    private void MainPage_SizeChanged(object sender, EventArgs e)
    {
        DefineFontSize("FontSizeLarge", 38, 30);
        DefineFontSize("FontSizeBody", 48, 42);
        DefineFontSize("FontSizeSmall", 52, 48);
    }

    private void DefineFontSize(string resourceKey, int charsInLine, int linesInPage)
    {
        var size1 = Math.Round(Width / charsInLine) * 2;
        var size2 = Math.Round(Height / linesInPage);
        App.Current.Resources[resourceKey] = Math.Min(size1, size2);
    }
}

	



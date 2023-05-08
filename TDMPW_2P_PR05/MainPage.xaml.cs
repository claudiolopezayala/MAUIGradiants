using System.Reflection;

namespace TDMPW_2P_PR05;

public partial class MainPage : ContentPage
{
	GradientStop[] stops = new GradientStop[6];
	Label[] labels = new Label[6];


	public MainPage()
	{
		InitializeComponent();
		stops[0] = this.stop0;
		stops[1] = this.stop1;
		stops[2] = this.stop2;
		stops[3] = this.stop3;
		stops[4] = this.stop4;
		stops[5] = this.stop5;

		labels[0] = this.lblColor0;
		labels[1] = this.lblColor1;
		labels[2] = this.lblColor2;
		labels[3] = this.lblColor3;
		labels[4] = this.lblColor4;
		labels[5] = this.lblColor5;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Random rnd = new Random();
		for (int i = 0; i < stops.Length; i++)
		{
			Color color = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
			stops[i].Color = color;
			labels[i].Text = color.ToRgbaHex();
        }
    }
}


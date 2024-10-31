namespace Scroller;

public partial class Prompter : ContentPage
{
	public Prompter()
	{
        InitializeComponent();
	}
	public static List<string> stringArray = [];
	public int index = 0;

	private void PreviousBtnClicked(object sender, EventArgs e) 
	{
		if (index == 0)
		{
			SentenceLabel.Text = stringArray[0];
		}
        else
        {
            index--;
            SentenceLabel.Text = stringArray[index];
        }
    }

	private void NextBtnClicked(object sender, EventArgs e) 
	{
		if (index == stringArray.Count - 1)
		{
			SentenceLabel.Text = stringArray[stringArray.Count - 1];
		}
		else 
		{
            index++;
            SentenceLabel.Text = stringArray[index];
		}
	}
}
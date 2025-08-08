namespace AplicacionDePrueba
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      
    }

    private void btnChangeBackgroundColor_Click(object sender, EventArgs e)
    {
      // Change the background color to a random color
      Random random = new Random();
      int red = random.Next(256);
      int green = random.Next(256);
      int blue = random.Next(256);
      this.BackColor = System.Drawing.Color.FromArgb(red, green, blue);

    }
  }
}

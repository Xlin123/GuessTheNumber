using System.Windows;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        

        

        private void clicked_Click(object sender, RoutedEventArgs e)
        {
            System.Random rnd = new System.Random();
            int RandomOutput = rnd.Next(1,100);
            string input = Input.Text;
            int.TryParse(input, out int TrueOutput);
            if (RandomOutput == TrueOutput)
            {
                Winner.Text = "WINNER!!!!!!!";
                Winner.Visibility = Visibility.Visible;
            }
            else
            {
                Winner.Text = "You lose. Try again.";
            }
           
        }
    }
}

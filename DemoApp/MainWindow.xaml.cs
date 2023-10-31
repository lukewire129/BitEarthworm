using Jamesnet.Wpf.Controls;

namespace DemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DarkThemeWindow
    {
        public MainWindow()
        {
            InitializeComponent ();
            
            for(int i= 0; i < 900; i++)
            {
                this.aa.Items.Add ("");
            }
        }
    }
}

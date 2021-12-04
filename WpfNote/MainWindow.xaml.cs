using System.Windows;

namespace WpfNote
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.DescriptionText.Text);
        }
    }
}
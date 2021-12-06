using System.Windows;
using System.Windows.Controls;

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
            MessageBox.Show($"The Description is : {DescriptionText.Text}");
        }

        private void ResetButton_OnClick(object sender, RoutedEventArgs e)
        {
            WeldCheckbox.IsChecked = AssemblyCheckbox.IsChecked = PlasmaCheckbox.IsChecked =
                LaserCheckbox.IsChecked = PurchaseCheckbox.IsChecked = LatheCheckbox.IsChecked =
                    DrillCheckbox.IsChecked = FoldCheckbox.IsChecked = RollCheckbox.IsChecked =
                        SawCheckbox.IsChecked = SawCheckbox.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            LengthText.Text += ((CheckBox) sender).Content;
        }
    }
}
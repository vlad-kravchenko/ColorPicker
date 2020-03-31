using System.Windows;
using System.Windows.Media;

namespace ColorPicker
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RedSlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Rectangle.Fill = new SolidColorBrush(Color.FromRgb((byte) RedSlider.Value, (byte) GreenSlider.Value, (byte) BlueSlider.Value));
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Rectangle.Fill.ToString());
            Clipboard.SetText(Rectangle.Fill.ToString());
        }
    }
}
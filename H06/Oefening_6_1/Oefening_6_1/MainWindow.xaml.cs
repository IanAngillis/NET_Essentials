using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Oefening_6_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            sliderSlider_Slider.ValueChanged += SliderSlider_Slider_ValueChanged;
        }

        private void SliderSlider_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            currentValueTextBlock_TextBlock.Text = Convert.ToString(sliderSlider_Slider.Value);
        }

        private void adjustButton_Button_Click(object sender, RoutedEventArgs e)
        {
            int newMax = Convert.ToInt32(maximumTextBox_TextBox.Text);
            int newMin = Convert.ToInt32(minimumTextBox_TextBox.Text);

            sliderSlider_Slider.Maximum = newMax;
            sliderSlider_Slider.Minimum = newMin;

            maximumTextBlock_TextBlock.Text = Convert.ToString(sliderSlider_Slider.Maximum);
            minimumTextBlock_TextBlock.Text = Convert.ToString(sliderSlider_Slider.Minimum);


        }
    }
}

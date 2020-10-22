
using System.Windows;

using System.Windows.Input;
using System.Windows.Markup;

namespace UTF2_EJER6
{

    public partial class MainWindow : Window, IComponentConnector
    {


        public MainWindow()
        {
            InitializeComponent();           
        }



       

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (imagen1Image.IsMouseOver)
            {
                imagen1Image.Opacity = 1;
            }
            else
                imagen1Image.Opacity = 0.5;
            if (imagen2Image.IsMouseOver)
            {
                imagen2Image.Opacity = 1;
            }
            else
                imagen2Image.Opacity = 0.5;
            if (imagen3Image.IsMouseOver)
            {
                imagen3Image.Opacity = 1;
            }
            else
                imagen3Image.Opacity = 0.5;
        }
    }
}

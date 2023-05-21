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

namespace WpfAppTest1
{
    public class AktuelleSpannung
    {
        public string Spannung { get; set; }
    }
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AktuelleSpannung SpannungSource;
        public MainWindow()
        {
            SpannungSource = new AktuelleSpannung();
            InitializeComponent();
        }
    }
}

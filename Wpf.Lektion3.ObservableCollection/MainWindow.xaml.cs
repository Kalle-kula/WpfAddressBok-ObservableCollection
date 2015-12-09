using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Wpf.Lektion3.ObservableCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> personer;
        public MainWindow()
        {
            InitializeComponent();
            personer = new ObservableCollection<Person>();
            DataContext = personer;
        }
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            personer.Add(new Person() { Name = txtName.Text, Emejl = txtEmejl.Text});
            txtName.Text = string.Empty;
            txtEmejl.Text = string.Empty;
        }
    }
}

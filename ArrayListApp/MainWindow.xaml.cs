using System;
using System.Collections;
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

namespace ArrayListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList List;
        string AllList = "";
        public MainWindow()
        {
            InitializeComponent();
            List = new ArrayList();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "";
            
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "") {
                TextBox.Text = "Fill something";
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            List.Add(TextBox.Text);
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            List.Remove(TextBox.Text);
        }

        private void ShowAllButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (string a_list in List) {
                AllList = AllList + "    "+a_list+"\n";
            }
            MessageBox.Show("List :\n"+AllList);
            AllList = "";
        }
    }
}

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

namespace projectcheckbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtname.Text != "" && pwdpassword.Password != "" && txtage.Text != "")
            {
                MessageBoxResult result = MessageBox.Show("Are You sure submit", "Conform", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {
                    MessageBox.Show("Submited", "Conform", MessageBoxButton.OK);
                    String a = txtname.Text;
                    String b = pwdpassword.Password;
                    String c = txtage.Text;
                    String d = (String)Chkmale.Content;
                    String f = (String)Chkfmale.Content;
                    String q = "User name is :" + a + "," + "Your password is :" + b + "," + "Your Age is :" + c + "," + "Your Gender:" + d + "," + "Your Gender:" + f +
                    MessageBox.Show(q, "Info") ; 
                }
            }
        }

        private void ChkBox_Click(object sender, RoutedEventArgs e)
        {
           if(Chkfmale.IsChecked == true)
            {
                MessageBox.Show("Female");
            }
            if (Chkmale.IsChecked == true)
            {
                MessageBox.Show("Male");

            }
            
        }
    }
}

       
        

        
    



/// Chapter No. 4		Exercise No. 1
/// File Name: MainWindow.xaml.cs
/// @author: Chester Brock 
/// Date:  Sep 19, 2021
///
/// Problem Statement:  Create a gui for the pig latin homeowrk
/// 
/// 
/// 
/// Overall Plan:
/// 1) Place two text boxes
/// 2) place two labels besides them 
/// 3) rename the items from the tool box
/// 4) link up homework 2 with the gui. 
///

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

namespace Lab1
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

        private void pigLatinButton_Click(object sender, RoutedEventArgs e)
        {
            String firstName = firstNameTextBox.Text;
            String lastName = lastNameTextBox.Text;
            String piglatinFirstName; 
            String piglatinLastName;
            firstName = firstName.ToLower();
            lastName = lastName.ToLower();

            piglatinFirstName = firstName.Substring(1, firstName.Length - 1) + firstName.Substring(0,1) + "ay";
            piglatinFirstName = piglatinFirstName.Substring(0, 1).ToUpper() + piglatinFirstName.Substring(1,piglatinFirstName.Length -1);

            piglatinLastName = lastName.Substring(1, lastName.Length - 1) + lastName.Substring(0, 1) + "ay";
            piglatinLastName = piglatinLastName.Substring(0, 1).ToUpper() + piglatinLastName.Substring(1, piglatinLastName.Length - 1);

            MessageBox.Show("Your name in piglatin is: " + piglatinFirstName + " " + piglatinLastName);
        }
    }
}

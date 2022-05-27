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
using Project_9;

namespace Project_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Project_9.Program.Main();
            TextBlock textBlock1 = new TextBlock();
            foreach (string el in Project_9.Program.messageList){
                textBlock1.Text = el;
            }
            //string message1 = Project_9.Program.messageList;
        }
    }
}

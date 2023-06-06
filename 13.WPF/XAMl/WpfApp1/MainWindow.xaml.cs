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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid grid = new Grid();
            this.Content = grid;

            Button btn = new Button();
            btn.FontSize = 32;
            
            WrapPanel wrpPnl = new WrapPanel();
            
            TextBlock tx1 = new TextBlock();
            TextBlock tx2 = new TextBlock();
            TextBlock tx3 = new TextBlock();

            tx1.Text = "Cli";
            tx2.Text= "ck m";
            tx3.Text= "e!";

            tx1.Foreground = Brushes.Red;
            tx2.Foreground = Brushes.Green;
            tx3.Foreground = Brushes.Yellow;
        
            wrpPnl.Children.Add(tx1);
            wrpPnl.Children.Add(tx2);
            wrpPnl.Children.Add(tx3);

            btn.Width= 250;
            btn.Height= 50;

            btn.Content = wrpPnl;
            grid.Children.Add(btn);
            this.Title = "Some XAML and C# coding";
        }
    }
}

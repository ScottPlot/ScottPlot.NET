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

namespace CustomMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // unsubscribe from the default right-click menu event
            WpfPlot1.RightClicked -= WpfPlot1.DefaultRightClickEvent;

            // add your own custom event
            WpfPlot1.RightClicked += DeployCustomMenu;
        }

        private void DeployCustomMenu(object sender, EventArgs e)
        {
            MenuItem addSinMenuItem = new MenuItem() { Header = "Add Sine Wave" };
            addSinMenuItem.Click += AddSine;

            MenuItem clearPlotMenuItem = new MenuItem() { Header = "Clear Plot" };
            clearPlotMenuItem.Click += ClearPlot;

            ContextMenu rightClickMenu = new ContextMenu();
            rightClickMenu.Items.Add(addSinMenuItem);
            rightClickMenu.Items.Add(clearPlotMenuItem);

            rightClickMenu.IsOpen = true;
        }

        private void AddSine(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            double[] data = ScottPlot.DataGen.Sin(51, phase: rand.NextDouble() * 1000);
            WpfPlot1.Plot.AddSignal(data);
            WpfPlot1.Plot.AxisAuto();
        }

        private void ClearPlot(object sender, RoutedEventArgs e)
        {
            WpfPlot1.Plot.Clear();
            WpfPlot1.Plot.AxisAuto();
        }
    }
}

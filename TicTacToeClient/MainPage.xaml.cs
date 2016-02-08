using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TicTacToeClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        public void mark(object sender, TappedRoutedEventArgs e)
        {
            var textblock = (TextBlock)sender;
            textblock.Text = " X";
            textblock.Tapped -= mark;
            Debug.WriteLine(textblock.Name = "Was hit");
            ComputerTurn();
        }

        public void ComputerTurn()
        {
            var box = (TextBlock)FindName("textBlock2");
            box.Text = "O";
            box.Tapped += null;
        }

        private void start(object sender, RoutedEventArgs e)
        {
            var myGrid = (Grid)FindName("myGrid");
            myGrid.Visibility = Visibility.Visible;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace KeyboardInputRFID
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private string RFIDString = "";
        private bool move = false;
        private Stopwatch stopwatch;

        public MainPage()
        {
            this.InitializeComponent();

            this.stopwatch = new Stopwatch();
            this.stopwatch.Start();
        }

        private void EnableListener(object sender, RoutedEventArgs args)
        {
            CoreWindow.GetForCurrentThread().KeyDown += this.OnKeyDown;
        }

        private void DisableListener(object sender, RoutedEventArgs args)
        {
            CoreWindow.GetForCurrentThread().KeyDown -= this.OnKeyDown;
        }

        private void OnKeyDown(CoreWindow sender, KeyEventArgs args)
        {

            if (args.VirtualKey != VirtualKey.Enter && args.VirtualKey != VirtualKey.Shift)
            {
                this.RFIDString += this.GetKeyboardChar(args.VirtualKey);
            }

            if (this.RFIDString.Length >= 24)
            {
                this.RFIDContent.Text = this.RFIDString;
                this.RFIDString = "";
            }
        }

        private void Reset(object sender, RoutedEventArgs args)
        {
            this.RFIDContent.Text = "";
        }

        private string GetKeyboardChar(VirtualKey key)
        {
            switch (key)
            {
                case VirtualKey.Number0:
                    return "0";
                case VirtualKey.Number1:
                    return "1";
                case VirtualKey.Number2:
                    return "2";
                case VirtualKey.Number3:
                    return "3";
                case VirtualKey.Number4:
                    return "4";
                case VirtualKey.Number5:
                    return "5";
                case VirtualKey.Number6:
                    return "6";
                case VirtualKey.Number7:
                    return "7";
                case VirtualKey.Number8:
                    return "8";
                case VirtualKey.Number9:
                    return "9";
                case VirtualKey.A:
                    return "A";
                case VirtualKey.B:
                    return "B";
                case VirtualKey.C:
                    return "C";
                case VirtualKey.D:
                    return "D";
                case VirtualKey.E:
                    return "E";
                case VirtualKey.F:
                    return "F";
                default:
                    return "";
            }
        }
    }
}

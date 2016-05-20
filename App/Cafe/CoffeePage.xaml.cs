using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App.Cafe
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        public CoffeePage()
        {
            this.InitializeComponent();
        }

        string roast = "";
        string sweetner = "";
        string cream = "";

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            var roasts = new string[] { "Dark", "Medium" };
            var sweetners = new string[] { "Sugar" };
            var creams = new string[] { "2% Milk", "Whole Milk" };
            List<string> text = new List<string>();

            var flyout = sender as MenuFlyoutItem;
            switch(flyout.Name)
            {
                case "RoastNone":
                    roast = "";
                    break;
                case "RoastDark":
                    roast = "Dark";
                    break;
                case "RoastMedium":
                    roast = "Medium";
                    break;
                case "SweetenerNone":
                    sweetner = "";
                    break;
                case "SweetenerSugar":
                    sweetner = "Sugar";
                    break;
                case "CreamNone":
                    cream = "";
                    break;
                case "Cream2Milk":
                    cream = "2% Milk";
                    break;
                case "CreamWholeMilk":
                    cream = "Whole Milk";
                    break;
            }

            if(!string.IsNullOrEmpty(roast))
            {
                text.Add(roast);
            }
            if (!string.IsNullOrEmpty(sweetner))
            {
                text.Add(sweetner);
            }
            if (!string.IsNullOrEmpty(cream))
            {
                text.Add(cream);
            }
            if (string.IsNullOrEmpty(roast))
            {
                text.Clear();
            }

            CoffeeTextBlock.Text = string.Join(" + ", text);
        }
    }
}

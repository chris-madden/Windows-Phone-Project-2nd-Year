using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Hackathon
{
    public partial class StamfordBridge : PhoneApplicationPage
    {
        public StamfordBridge()
        {
            InitializeComponent();
        }

        //Increases page opacity to 100%
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            LargeTheBridgeStk.Opacity = 1;

        }

        //Makes menu visable or collasped depending on its current status
        private void menuFromStamfordBridge_Click(object sender, RoutedEventArgs e)
        {

            //Make menu visible or collapse it
            if (MenuBoxTheBridge.Visibility == System.Windows.Visibility.Visible)
            {
                MenuBoxTheBridge.Visibility = System.Windows.Visibility.Collapsed;

                LargeTheBridgeStk.Opacity = 1;
            }
            else
            {
                MenuBoxTheBridge.Visibility = System.Windows.Visibility.Visible;

                LargeTheBridgeStk.Opacity = .5;

                MenuBoxTheBridge.Opacity = 1;
            }

        }//End menuFromStamfordBridge_Click

        //Home Page Navigation
        private void homePageBridge_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxTheBridge.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Trophy Page Navigation
        private void trophyPageBridge_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/TrophyCabinet.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxTheBridge.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Player Page Navigation
        private void playersPageBridge_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/Players.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxTheBridge.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Squad Page Navigation
        private void squadPageBridge_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/restOfSquad.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxTheBridge.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Stamford Bridge Navigation
        private void stamfordBridgeBridge_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/StamfordBridge.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxTheBridge.Visibility = System.Windows.Visibility.Collapsed;

            LargeTheBridgeStk.Opacity = 1;

        }

        //Facts Page Navigation
        private void factsBridge_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/Facts.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxTheBridge.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Resources Page Navigation
        private void resourcesBridge_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/ContentResources.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxTheBridge.Visibility = System.Windows.Visibility.Collapsed;

        }//End resourcesBridge_Click method

    }//End StamfordBridge Class

}//End namespace
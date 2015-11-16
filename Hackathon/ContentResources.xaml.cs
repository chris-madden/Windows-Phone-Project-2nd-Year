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
    public partial class ContentResources : PhoneApplicationPage
    {
        public ContentResources()
        {
            InitializeComponent();
        }

        //Increases page opacity to 100%
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            LargeResourcesStk.Opacity = 1;

        }

        //Makes menu visable or collasped depending on its current status
        private void menuFromResources_Click(object sender, RoutedEventArgs e)
        {

            //Make menu visible or collapse it
            if (MenuBoxResources.Visibility == System.Windows.Visibility.Visible)
            {
                MenuBoxResources.Visibility = System.Windows.Visibility.Collapsed;

                LargeResourcesStk.Opacity = 1;
            }
            else
            {
                MenuBoxResources.Visibility = System.Windows.Visibility.Visible;

                LargeResourcesStk.Opacity = .5;

                MenuBoxResources.Opacity = 1;
            }

        }//End menuFromResources_Click method

        //Home Page Navigation
        private void homePageResources_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxResources.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Trophy Page Navigation
        private void trophyPageResources_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/TrophyCabinet.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxResources.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Player Page Navigation
        private void playersPageResources_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/Players.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxResources.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Squad Page Navigation
        private void squadPageResources_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/restOfSquad.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxResources.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Stamford Bridge Navigation
        private void stamfordBridgeResources_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/StamfordBridge.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxResources.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Facts Page Navigation
        private void factsResources_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/Facts.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxResources.Visibility = System.Windows.Visibility.Collapsed;

        }

        private void resourcesResources_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/ContentResources.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxResources.Visibility = System.Windows.Visibility.Collapsed;

            LargeResourcesStk.Opacity = 1;

        }

    }//End ContentResources Class

}//End namespace
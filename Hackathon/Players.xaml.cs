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
    public partial class Players : PhoneApplicationPage
    {
        public Players()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            LargePlayerStk.Opacity = 1;

        }

        //Make menu visible or collapse it
        private void menuFromPlayers_Click(object sender, RoutedEventArgs e)
        {

            //Make menu visible or collapse it
            if (MenuBoxPlayers.Visibility == System.Windows.Visibility.Visible)
            {
                MenuBoxPlayers.Visibility = System.Windows.Visibility.Collapsed;

                LargePlayerStk.Opacity = 1;
            }
            else
            {
                MenuBoxPlayers.Visibility = System.Windows.Visibility.Visible;

                LargePlayerStk.Opacity = .5;

                MenuBoxPlayers.Opacity = 1;
            }

        }//End menuFromPlayers_Click

        //Home Page Navigation
        private void homePagePlayers_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxPlayers.Visibility = System.Windows.Visibility.Collapsed;

            LargePlayerStk.Opacity = 1;

        }

        //Trophy Page Navigation
        private void trophyPagePlayers_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/TrophyCabinet.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxPlayers.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Players Page Navigation
        private void playersPagePlayers_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/Players.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxPlayers.Visibility = System.Windows.Visibility.Collapsed;

            LargePlayerStk.Opacity = 1;

        }

        //Squad Page Navigation
        private void squadPagePlayers_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/restOfSquad.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxPlayers.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Stamford Bridge Page Navigation
        private void stamfordBridgePlayers_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/StamfordBridge.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxPlayers.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Facts page navigation
        private void factsPlayers_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/Facts.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxPlayers.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Resources page Navigation
        private void resourcesPlayers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ContentResources.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxPlayers.Visibility = System.Windows.Visibility.Collapsed;
        }//End resourcesPlayers_Click

    }//End Players class

}//End namespace
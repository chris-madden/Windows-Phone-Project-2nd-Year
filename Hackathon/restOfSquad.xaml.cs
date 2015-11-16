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
    public partial class restOfSquad : PhoneApplicationPage
    {
        public restOfSquad()
        {
            InitializeComponent();
        }

        //Increases page opacity to 100%
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            largeStkSquad.Opacity = 1;

        }

        //Menu button
        //Will appear disappear depending in it's current visibilty status
        private void menuFromSquad_Click(object sender, RoutedEventArgs e)
        {

            //Make menu visible or collapse it
            if (MenuBoxSquad.Visibility == System.Windows.Visibility.Visible)
            {
                MenuBoxSquad.Visibility = System.Windows.Visibility.Collapsed;

                largeStkSquad.Opacity = 1;
            }
            else
            {
                MenuBoxSquad.Visibility = System.Windows.Visibility.Visible;

                largeStkSquad.Opacity = .5;

                MenuBoxSquad.Opacity = 1;
            }

        }

        //Home Page Navigation
        private void homePageSquad_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxSquad.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Trophy Page Navigation
        private void trophyPageSquad_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/TrophyCabinet.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxSquad.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Player Page Navigation
        private void playersPageSquad_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/Players.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxSquad.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Squad Page Navigation
        private void squadPageSquad_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/restOfSquad.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxSquad.Visibility = System.Windows.Visibility.Collapsed;

            largeStkSquad.Opacity = 1;

        }

        //Stamford Bridge Navigation
        private void stamfordBridgeSquad_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/StamfordBridge.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxSquad.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Facts Page Navigation
        private void factsSquad_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/Facts.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxSquad.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Resources Page Navigation
        private void resourcesSquad_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/ContentResources.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxSquad.Visibility = System.Windows.Visibility.Collapsed;

        }//End resourcesSquad_Click method

    }//End restOfSquad Class

}//End namespace
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
    public partial class Facts : PhoneApplicationPage
    {
        public Facts()
        {
            InitializeComponent();
        }

        //Increases page opacity to 100%
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            LargeFactStk.Opacity = 1;

        }

        //Makes menu visable or collasped depending on its current status
        private void menuFromFacts_Click(object sender, RoutedEventArgs e)
        {

            //Make menu visible or collapse it
            if (MenuBoxFacts.Visibility == System.Windows.Visibility.Visible)
            {
                MenuBoxFacts.Visibility = System.Windows.Visibility.Collapsed;

                LargeFactStk.Opacity = 1;
            }
            else
            {
                MenuBoxFacts.Visibility = System.Windows.Visibility.Visible;

                LargeFactStk.Opacity = .5;

                MenuBoxFacts.Opacity = 1;
            }

        }//End menuFromFacts_Click method

        //Home Page Navigation
        private void homePageFacts_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxFacts.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Trophy Page Navigation
        private void trophyPageFacts_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/TrophyCabinet.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxFacts.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Player Page Navigation
        private void playersPageFacts_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/Players.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxFacts.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Squad Page Navigation
        private void squadPageFacts_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/restOfSquad.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxFacts.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Stamford Bridge Navigation
        private void stamfordBridgeFacts_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/StamfordBridge.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxFacts.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Facts Page Navigation
        private void factsFacts_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/Facts.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxFacts.Visibility = System.Windows.Visibility.Collapsed;

            LargeFactStk.Opacity = 1;

        }

        //Resources Page Navigation
        private void resourcesFacts_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/ContentResources.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBoxFacts.Visibility = System.Windows.Visibility.Collapsed;

        }//End resourcesSquad_Click method

    }//End class Facts

}//End namespace
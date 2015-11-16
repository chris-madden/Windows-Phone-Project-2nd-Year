using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Hackathon.Resources;

namespace Hackathon
{
    public partial class MainPage : PhoneApplicationPage
    {
       
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }

        //Increases page opacity to 100%
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            MainPageOuterStk.Opacity = 1;
        
        }
        
        //Menu button
        //Will appear disappear depending in it's current visibilty status
        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            
            //Make menu visible or collapse it
            if (MenuBox.Visibility == System.Windows.Visibility.Visible)
            {
                MenuBox.Visibility = System.Windows.Visibility.Collapsed;

                MainPageOuterStk.Opacity = 1;
            }
            else
            {
                MenuBox.Visibility = System.Windows.Visibility.Visible;

                MainPageOuterStk.Opacity = .5;

                MenuBox.Opacity = 1;
            }

        }//End menuButton_Click method

        //Trophy Page navigation
        private void trophyPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TrophyCabinet.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBox.Visibility = System.Windows.Visibility.Collapsed;
        }//End menuButton_Click

        //Players page navigation
        private void playersPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Players.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBox.Visibility = System.Windows.Visibility.Collapsed;
        }

        //Squad page navigation
        private void squadPage_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/restOfSquad.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBox.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Stamford Bridge page navigation
        private void stamfordBridge_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/StamfordBridge.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBox.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Facts page navigation
        private void facts_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/Facts.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBox.Visibility = System.Windows.Visibility.Collapsed;

        }

        //Home Page Navigation
        private void homePage_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBox.Visibility = System.Windows.Visibility.Collapsed;

            MainPageOuterStk.Opacity = 1;

        }

        //Resources Page Navigation
        private void resources_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/ContentResources.xaml", UriKind.RelativeOrAbsolute));

            //Menu will close when the button is clicked
            MenuBox.Visibility = System.Windows.Visibility.Collapsed;

        }//End resources_Click
       
    }//End class MainPage

}//End of namespace 
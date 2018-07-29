using ApiDesktopClient.Views;
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


namespace ApiDesktopClient
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            // по умолчанию открываем страницу home.xaml
            myFrame.Navigate(typeof(PilotView));
            TitleTextBlock.Text = "Pilot";
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Pilot.IsSelected)
            {
                myFrame.Navigate(typeof(PilotView));
                TitleTextBlock.Text = "Pilots";
            }
            else if (Stewardess.IsSelected)
            {
                myFrame.Navigate(typeof(StewardessView));
                TitleTextBlock.Text = "Stewardesses";
            }
            else if (Ticket.IsSelected)
            {
                myFrame.Navigate(typeof(TicketView));
                TitleTextBlock.Text = "Tickets";
            }
            else if (AirCraftType.IsSelected)
            {
                myFrame.Navigate(typeof(AirCraftTypeView));
                TitleTextBlock.Text = "AirCraftTypes";
            }
            else if (Crew.IsSelected)
            {
                myFrame.Navigate(typeof(CrewView));
                TitleTextBlock.Text = "Crews";
            }
            else if (Departure.IsSelected)
            {
                myFrame.Navigate(typeof(DepartureView));
                TitleTextBlock.Text = "Departures";
            }
            else if (Flight.IsSelected)
            {
                myFrame.Navigate(typeof(FlightView));
                TitleTextBlock.Text = "Flights";
            }
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
        }
    }
}

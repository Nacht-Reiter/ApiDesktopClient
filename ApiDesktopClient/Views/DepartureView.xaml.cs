using ApiDesktopClient.Models;
using ApiDesktopClient.Services;
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

namespace ApiDesktopClient.Views
{

    public sealed partial class DepartureView : Page
    {

        private GenericService<DepartureModel> service;
        private DepartureModel selectedItem;
        public DepartureView()
        {
            service = new GenericService<DepartureModel>("http://localhost:51460/api/Departures/");
            this.InitializeComponent();
            selectedItem = new DepartureModel();
            Refresh();
        }



        private async void Refresh()
        {
            this.itemsList.ItemsSource = await service.GetAll();
        }



        private async void Save(object sender, RoutedEventArgs e)
        {
            if (selectedItem.Id == 0)
            {
                await service.Add(selectedItem);
            }
            else
            {
                await service.Update(selectedItem.Id, selectedItem);
            }
            Refresh();
        }

        private async void Delete(object sender, RoutedEventArgs e)
        {
            await service.Delete(selectedItem.Id);
            Refresh();
        }

        private void itemsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedItem = (DepartureModel)itemsList.SelectedItem;
        }

        private async void Add(object sender, RoutedEventArgs e)
        {
            var items = await service.GetAll();
            items.Add(new DepartureModel { Id = 0 });
            this.itemsList.ItemsSource = items;
            itemsList.SelectedIndex = itemsList.Items.Count - 1;
        }
    }
}

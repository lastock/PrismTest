﻿using System.Windows.Input;
using Xamarin.Forms;


namespace CustomListViewControl
{
    public class CustomListView : Xamarin.Forms.ListView
    {
        public static readonly BindableProperty ItemTappedCommandProperty =
            BindableProperty.Create("ItemTappedCommand",
                typeof(ICommand),
                typeof(ListView),
                null);
        public ICommand ItemTappedCommand
        {
            get { return (ICommand)GetValue(ItemTappedCommandProperty); }
            set
            {
                SetValue(ItemTappedCommandProperty, value);
            }
        }

        public CustomListView() : base()
        {
            Initialize();
        }
        public CustomListView(Xamarin.Forms.ListViewCachingStrategy cachingStrategy)
            : base(cachingStrategy)
        {
            Initialize();
        }
        private void Initialize()
        {
            ItemTapped += ListView_ItemTapped;
        }
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (ItemTappedCommand != null && ItemTappedCommand.CanExecute(null))
                ItemTappedCommand.Execute(e.Item);
        }

    }

}

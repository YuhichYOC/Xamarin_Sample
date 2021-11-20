using BlankApp2.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankApp2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage1View : ContentView
    {
        public static readonly BindableProperty RowsProperty = BindableProperty.Create(nameof(Rows), typeof(ObservableCollection<TestDataRow>), typeof(TabPage1View));

        public TabPage1View()
        {
            InitializeComponent();
            this.Content.BindingContext = this;
        }

        public ObservableCollection<TestDataRow> Rows
        {
            get => (ObservableCollection<TestDataRow>)GetValue(RowsProperty);
            set => SetValue(RowsProperty, value);
        }

        private void BCommand(object s, EventArgs e)
        {
            Console.WriteLine(string.Format("{0}, {1}", HeaderScrollView.Width, Header.Width));
            Console.WriteLine(string.Format("{0}, {1}", BodyScrollView.Width, Body.Width));
        }
    }
}
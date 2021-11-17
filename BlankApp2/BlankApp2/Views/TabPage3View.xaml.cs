using BlankApp2.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankApp2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage3View : ContentView
    {
        public static readonly BindableProperty RowsProperty = BindableProperty.Create(nameof(Rows), typeof(ObservableCollection<TestDataRow>), typeof(TabPage3View));

        public TabPage3View()
        {
            InitializeComponent();
            this.Content.BindingContext = this;
        }

        public ObservableCollection<TestDataRow> Rows
        {
            get => (ObservableCollection<TestDataRow>)GetValue(RowsProperty);
            set => SetValue(RowsProperty, value);
        }
    }
}
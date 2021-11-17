using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace BlankApp2.Models
{
    public class TestDataRow : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string property1;

        private string property2;

        private string property3;

        private string property4;

        private string property5;

        private string property6;

        private string rowSpan;

        public string Property1
        {
            get { return property1; }
            set
            {
                if (property1 != value)
                {
                    property1 = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Property2
        {
            get { return property2; }
            set
            {
                if (property2 != value)
                {
                    property2 = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Property3
        {
            get { return property3; }
            set
            {
                if (property3 != value)
                {
                    property3 = value;
                    NotifyPropertyChanged();
                }
                RowSpan = property3.Equals(property6) ? "3" : "1";
            }
        }

        public string Property4
        {
            get { return property4; }
            set
            {
                if (property4 != value)
                {
                    property4 = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Property5
        {
            get { return property5; }
            set
            {
                if (property5 != value)
                {
                    property5 = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Property6
        {
            get { return property6; }
            set
            {
                if (property6 != value)
                {
                    property6 = value;
                    NotifyPropertyChanged();
                }
                RowSpan = property6.Equals(property3) ? "3" : "1";
            }
        }

        public string RowSpan
        {
            get { return rowSpan; }
            set
            {
                if (rowSpan != value)
                {
                    rowSpan = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ICommand ButtonCommand { get; set; }

        public TestDataRow()
        {
            property1 = "";
            property2 = "";
            property3 = "";
            property4 = "";
            property5 = "";
            property6 = "";
            rowSpan = "1";
        }

        private void NotifyPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
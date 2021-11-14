using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace BlankApp2.Models
{
    internal class TestData01
    {
        public ObservableCollection<TestDataRow> Rows { get; set; }

        public TestData01()
        {
            Rows = new ObservableCollection<TestDataRow>();
            Rows.Add(new TestDataRow() { Property1 = "a1", Property2 = "a2", Property3 = "a3", Property4 = "a4", Property5 = "a5", Property6 = "a6" });
            Rows.Add(new TestDataRow() { Property1 = "b1", Property2 = "b2", Property3 = "b3", Property4 = "b4", Property5 = "b5", Property6 = "b6" });
            Rows.Add(new TestDataRow() { Property1 = "c1", Property2 = "c2", Property3 = "c3", Property4 = "c4", Property5 = "c5", Property6 = "c6" });
            Rows.Add(new TestDataRow() { Property1 = "d1", Property2 = "d2", Property3 = "d3", Property4 = "d4", Property5 = "d5", Property6 = "d6" });
            Rows.Add(new TestDataRow() { Property1 = "e1", Property2 = "e2", Property3 = "e3", Property4 = "e4", Property5 = "e5", Property6 = "e6" });
            Rows.Add(new TestDataRow() { Property1 = "f1", Property2 = "f2", Property3 = "f3", Property4 = "f4", Property5 = "f5", Property6 = "f6" });
            Rows.Add(new TestDataRow() { Property1 = "g1", Property2 = "g2", Property3 = "g3", Property4 = "g4", Property5 = "g5", Property6 = "g6" });
            Rows.Add(new TestDataRow() { Property1 = "h1", Property2 = "h2", Property3 = "h3", Property4 = "h4", Property5 = "h5", Property6 = "h6" });
            Rows.Add(new TestDataRow() { Property1 = "i1", Property2 = "i2", Property3 = "i3", Property4 = "i4", Property5 = "i5", Property6 = "i6" });
            Rows.Add(new TestDataRow() { Property1 = "j1", Property2 = "j2", Property3 = "j3", Property4 = "j4", Property5 = "j5", Property6 = "j6" });
        }

        public void AddButtonCommand(ICommand arg)
        {
            Rows.ToList().ForEach(row => row.ButtonCommand = arg);
        }
    }
}
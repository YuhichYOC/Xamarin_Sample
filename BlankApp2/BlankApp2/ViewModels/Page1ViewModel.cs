using BlankApp2.Models;

namespace BlankApp2.ViewModels
{
    internal class Page1ViewModel
    {
        public TestData01 Data { get; set; }

        public Page1ViewModel()
        {
            Data = new TestData01();
        }
    }
}
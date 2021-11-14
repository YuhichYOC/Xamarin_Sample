using BlankApp2.Models;
using System;
using System.Windows.Input;

namespace BlankApp2.ViewModels
{
    internal class Page1ViewModel
    {
        public TestData01 Data { get; set; }

        public Page1ViewModel()
        {
            Data = new TestData01();
            Data.AddButtonCommand(new Page1ButtonCommand());
        }
    }

    public class Page1ButtonCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Console.WriteLine(@"ButtonCommand " + parameter.ToString());
            Xamarin.Forms.DependencyService.Get<BlankApp2.Infrastructure.IToaster>().Show(@"ButtonCommand " + parameter.ToString());
        }
    }
}
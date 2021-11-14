using Android.Widget;

using BlankApp2.Infrastructure;

[assembly: Xamarin.Forms.Dependency(typeof(BlankApp2.Droid.Toaster))]
namespace BlankApp2.Droid
{
    public class Toaster : IToaster
    {
        public void Show(string arg)
        {
            Toast t = Toast.MakeText(Android.App.Application.Context, arg, ToastLength.Short);
            t.Show();
        }
    }
}
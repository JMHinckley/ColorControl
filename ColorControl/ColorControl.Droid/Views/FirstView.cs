using Android.App;
using Android.OS;

// 1.
using Android.Widget;   // Need this for declaring TextView widget reference

namespace ColorControl.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : BaseView
    {
        // 2.
        private TextView _tv;   // TextView widget reference

        protected override int LayoutResource => Resource.Layout.FirstView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);

            // 3.
            _tv = FindViewById<TextView>(Resource.Id.textView1);    // reference to the TextView widget

            // 4.
            _tv.SetTextColor(Android.Graphics.Color.Red);   // Set the text color to red
        }
    }
}

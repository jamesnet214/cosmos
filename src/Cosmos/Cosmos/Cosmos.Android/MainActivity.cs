using Android.App;
using Android.Content.PM;
using Avalonia.Android;

namespace Cosmos.Android;

[Activity(Label = "Cosmos.Android", Theme = "@style/MyTheme.NoActionBar", Icon = "@drawable/icon",
    LaunchMode = LaunchMode.SingleTop,
    ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity
{
}
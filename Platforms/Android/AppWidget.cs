// Add Exported = true for your app to run as expected in Android 12 and above.
using Android.App;
using Android.Appwidget;
using Android.Content;
using Android.Widget;
using WidgetSample;

[BroadcastReceiver(Label = "WidgetSample", Exported = true)]
[IntentFilter(new string[] { "android.appwidget.action.APPWIDGET_UPDATE" })]
[MetaData("android.appwidget.provider", Resource = "@xml/appwidgetprovider")]
[Service(Exported = true)]
public class AppWidget : AppWidgetProvider
{
    public override void OnUpdate(Context context, AppWidgetManager appWidgetManager, int[] appWidgetIds)
    {
        for (int i = 0; i < appWidgetIds.Length; i++)
        {
            int appWidgetId = appWidgetIds[i];
            UpdateAppWidget(context, appWidgetManager, appWidgetId, "Initial text");
        }
    }

    public static void UpdateAppWidget(Context context, AppWidgetManager appWidgetManager, int appWidgetId, string newText)
    {
        RemoteViews views = new RemoteViews(context.PackageName, Microsoft.Maui.Resource.Layout.Widget);
        // Here you can set your data
        views.SetTextViewText(Microsoft.Maui.Resource.Id.widget_text, newText);
        appWidgetManager.UpdateAppWidget(appWidgetId, views);
    }

    public override void OnReceive(Context context, Intent intent) { }

}
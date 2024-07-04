using Android.Content;
using Android.Appwidget;
using WidgetSample.Services;

[assembly: Dependency(typeof(WidgetSample.Platforms.Android.WidgetUpdater))]
namespace WidgetSample.Platforms.Android
{
    public class WidgetUpdater : IWidgetUpdater
    {
        public void UpdateWidget(string text)
        {
            var context = global::Android.App.Application.Context;
            var appWidgetManager = AppWidgetManager.GetInstance(context);
            var componentName = new ComponentName(context, Java.Lang.Class.FromType(typeof(AppWidget)));
            var appWidgetIds = appWidgetManager.GetAppWidgetIds(componentName);

            for (int i = 0; i < appWidgetIds.Length; i++)
            {
                int appWidgetId = appWidgetIds[i];
                AppWidget.UpdateAppWidget(context, appWidgetManager, appWidgetId, text);
            }
        }
    }
}

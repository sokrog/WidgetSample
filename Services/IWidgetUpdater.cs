namespace WidgetSample.Services
{
    public interface IWidgetUpdater
    {
        // TODO how to update the widget text every 1-3 hours when app closed ?
        // Can update text on started or closed app
        void UpdateWidget(string text);
    }
}

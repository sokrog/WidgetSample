using WidgetSample.Services;

namespace WidgetSample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var widgetUpdater = Application.Current.Handler.MauiContext.Services.GetService<IWidgetUpdater>();
            widgetUpdater.UpdateWidget($"New Data for Widget {count}");

            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}

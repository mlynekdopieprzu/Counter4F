using Counter4F.Controls;

namespace Counter4F
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            
            InitializeComponent();
        }
        async void NewCounter(object sender, EventArgs e)
        {
            LayoutName.Children.Add(new CounterView(CounterTitle.Text));
            CounterTitle.Text = "Nazwa";
        }
    }

}

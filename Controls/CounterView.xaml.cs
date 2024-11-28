namespace Counter4F.Controls
{

    public partial class CounterView : ContentView
    {
        int count = 0;

        public CounterView(String title)
        {
            InitializeComponent();
            CounterTitle.Text = title;
        }
        public CounterView()
        {
            InitializeComponent();
        }
        private void OnAddClicked(object sender, EventArgs e)
        {
            count++;

                CounterLabel.Text = $"Counter is on {count}!";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
        private void OnMinusClicked(object sender, EventArgs e)
        {
            count--;

            CounterLabel.Text = $"Counter is on {count}!";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }

    }
}
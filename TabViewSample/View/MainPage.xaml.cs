using Syncfusion.Maui.TabView;

namespace TabViewSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if (tabView != null && call != null)
            {
                contentView.Content = new Call();
            }
        }

        private void tabView_SelectionChanged(object sender, TabSelectionChangedEventArgs e)
        {
            contentView.Content = null;
            // Assign content based on the new index
            switch (e.NewIndex)
            {
                case 0:
                    contentView.Content ??= new Call();
                    break;
                case 1:
                    contentView.Content ??= new Favorite();
                    break;
                case 2:
                    contentView.Content ??= new Contacts();
                    break;
                case 3:
                    contentView.Content ??= new More();
                    break;
            }
        }

        private void LeftArrowClicked(object sender, TappedEventArgs e)
        {
            if (tabView != null)
            {
                if (tabView.SelectedIndex > 0)
                {
                    tabView.SelectedIndex -= 1;
                }
            }
        }

        private void RightArrowClicked(object sender, TappedEventArgs e)
        {
            if (tabView != null)
            {
                if (tabView.SelectedIndex < tabView.Items.Count - 1)
                {
                    tabView.SelectedIndex += 1;
                }
            }
        }
    }

}

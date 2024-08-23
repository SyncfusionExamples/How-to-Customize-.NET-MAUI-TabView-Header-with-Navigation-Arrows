This article guides how to customize the [.NET MAUI Tab View](https://www.syncfusion.com/maui-controls/maui-tab-view) header by adding navigation arrows for the next and previous tabs.

**XAML Code**

The following XAML code snippet demonstrates how to set up the layout using a Grid control, which includes navigation arrows and the .NET MAUI Tab View.

```xml
<Border>
    <Grid ColumnDefinitions="50,*,50" HorizontalOptions="Center" RowDefinitions="50,*">
        <Label Text=">" Rotation="180" FontSize="Medium" VerticalTextAlignment="Center" 
               HorizontalTextAlignment="Center">
            <Label.GestureRecognizers>
                <TapGestureRecognizer Tapped="OnLeftArrowClicked"/>
            </Label.GestureRecognizers>
        </Label>
        <tabView:SfTabView x:Name="tabView" 
                           Grid.Column="1" 
                           SelectionChanged="OnSelectionChanged">
            <tabView:SfTabView.Items >
                <tabView:SfTabItem x:Name="call" Header="Call"/>

                <tabView:SfTabItem x:Name="favorite" Header="Favorite"/>

                <tabView:SfTabItem x:Name="contacts" Header="Contacts" />

                <tabView:SfTabItem x:Name="more" Header="More"/>
            </tabView:SfTabView.Items>
        </tabView:SfTabView>

        <Label Text=">" Grid.Column="2" FontSize="Medium" VerticalTextAlignment="Center" 
               HorizontalTextAlignment="Center">
            <Label.GestureRecognizers>
                <TapGestureRecognizer Tapped="OnRightArrowClicked"/>
            </Label.GestureRecognizers>
        </Label>

        <ContentView x:Name="contentView" Grid.Row="1" Grid.ColumnSpan="3"/>
    </Grid>
</Border>
```

**C#**

The following C# code handles the logic for updating the content based on the selected tab and managing the navigation between tabs.

```csharp
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        if(tabView != null && call != null)
        {
            contentView.Content = new Call();
        }
    }

    private void OnSelectionChanged(object sender, TabSelectionChangedEventArgs e)
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

    private void OnLeftArrowClicked(object sender, TappedEventArgs e)
    {
        if(tabView != null && tabView.SelectedIndex > 0)
        {
            tabView.SelectedIndex -= 1;
        }
    }

    private void OnRightArrowClicked(object sender, TappedEventArgs e)
    {
        if(tabView != null && tabView.SelectedIndex < tabView.Items.Count - 1)
        {
            tabView.SelectedIndex += 1;
        }
    }
}
```

- **Grid Layout**: The layout is structured using a Grid with three columns. The first and third columns contain the navigation arrows, while the middle column holds the .NET MAUI Tab View.
  
- **Navigation Arrows**: Two Label controls represent the left and right arrows. They utilize `TapGestureRecognizer` to handle click events for navigating between tabs.

- **TabView Control**: The .NET MAUI Tab View is positioned in the center column of the grid. It contains multiple tab items, and the [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_SelectionChanged) event is used to update the content displayed in the ContentView based on the selected tab.

- **ContentView**: A ContentView is placed below the Tab View to show the content corresponding to the selected tab.

- **Code-Behind Logic**: The constructor initializes the content of the first tab. The `OnSelectionChanged` event updates the ContentView based on the selected tab index, while the `OnLeftArrowClicked` and `OnRightArrowClicked` events adjust the `SelectedIndex` of the Tab View to navigate through the tabs.

**Output**

![TabView_Arrow_Navigation.gif](https://support.syncfusion.com/kb/agent/attachment/article/17139/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI4NTk1Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.ll9IZ0fxJIgADln6AG_0MZnO5p8JdXqkrL9w6Ps2tiA)
# How to set font styles for items in .NET MAUI ListView?
This example demonstrates how to set font styles for items in .NET MAUI ListView.

**[View document in Syncfusion .NET MAUI Knowledge Base](https://www.syncfusion.com/kb/13081/how-to-set-the-font-size-for-net-maui-listview-sflistview)**

## Sample

```xaml
<ListView:SfListView x:Name="listView"
                        ItemSize="70" GroupHeaderSize="50"
                        SelectionMode="Single"
                        IsStickyGroupHeader="True"
                        ItemsSource="{Binding ContactsInfo}"
                        AllowGroupExpandCollapse="True"
                        >
    <ListView:SfListView.BindingContext>
        <local:ViewModel />
    </ListView:SfListView.BindingContext>

    <ListView:SfListView.ItemTemplate>
        <DataTemplate>
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
    </ListView:SfListView.ItemTemplate>
</ListView:SfListView>

C#:

this.SizeChanged += MainPage_SizeChanged;

private void MainPage_SizeChanged(object sender, EventArgs e)
{
    DefineFontSize("FontSizeLarge", 38, 30);
    DefineFontSize("FontSizeBody", 48, 42);
    DefineFontSize("FontSizeSmall", 52, 48);
}

private void DefineFontSize(string resourceKey, int charsInLine, int linesInPage)
{
    var size1 = Math.Round(Width / charsInLine) * 2;
    var size2 = Math.Round(Height / linesInPage);
    App.Current.Resources[resourceKey] = Math.Min(size1, size2);
}
```

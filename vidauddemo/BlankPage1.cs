<Page
    x:Class="NavigationApp.BlankPage1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:NavigationApp"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    mc:Ignorable="d">

    <Grid Background = "{ThemeResource ApplicationPageBackgroundThemeBrush}" >
        < Button Name="btn2"
            Content="go to main page"
        HorizontalAlignment="Center"
        VerticalAlignment="Center"
                Click="btn2_Click"
        FontSize="20"/>
    </Grid>
</Page>

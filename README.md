এখানে আপনার GitHub রিপোর জন্য একটি পরিষ্কার ও প্রফেশনাল `README.md` ফাইল দিলাম। সরাসরি কপি করে ব্যবহার করতে পারেন।

```markdown
# ModernUI - WPF UI Example

A modern Windows desktop application built with **WPF** and **[WPF-UI](https://github.com/lepoco/wpfui)** library.  
This project demonstrates how to create a beautiful Fluent Design interface using the command line.

---

## Features

- Windows 11 style **Mica** backdrop
- Modern **TitleBar**
- Dark / Light theme support
- Clean Card-based layout
- Fluent buttons and icons

---

## Requirements

- [.NET 8](https://dotnet.microsoft.com/download) or later (recommended: .NET 10)
- Windows 10 / 11

---

## Create a New WPF-UI Project (CLI)

### 1. Create a new WPF project

```bash
dotnet new wpf -n ModernUI
cd ModernUI
```

### 2. Add WPF-UI package

```bash
dotnet add package WPF-UI
```

### 3. Update `App.xaml`

Replace the content of `App.xaml` with:

```xml
<Application x:Class="ModernUI.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:ui="http://schemas.lepo.co/wpfui/2022/xaml"
             StartupUri="MainWindow.xaml">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ui:ThemesDictionary Theme="Dark" />
                <ui:ControlsDictionary />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

### 4. Update `MainWindow.xaml`

```xml
<ui:FluentWindow x:Class="ModernUI.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:ui="http://schemas.lepo.co/wpfui/2022/xaml"
        Title="Modern UI"
        Width="900"
        Height="600"
        WindowBackdropType="Mica"
        ExtendsContentIntoTitleBar="True"
        WindowStartupLocation="CenterScreen">

    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <!-- Title Bar -->
        <ui:TitleBar Title="Modern UI" Grid.Row="0"/>

        <!-- Main Content -->
        <StackPanel Grid.Row="1" 
                    VerticalAlignment="Center" 
                    HorizontalAlignment="Center"
                    Margin="20">

            <ui:Card Padding="30" Margin="0,0,0,20">
                <StackPanel>
                    <TextBlock Text="Welcome to WPF-UI" 
                               FontSize="28" 
                               FontWeight="SemiBold"
                               HorizontalAlignment="Center"
                               Margin="0,0,0,15"/>

                    <TextBlock Text="A modern Fluent Design interface for WPF"
                               HorizontalAlignment="Center"
                               Opacity="0.7"
                               Margin="0,0,0,25"/>

                    <ui:Button Content="Click Me" 
                               Appearance="Primary"
                               HorizontalAlignment="Center"
                               Icon="{ui:SymbolIcon Fluent24}"
                               Width="160"
                               Height="40"/>
                </StackPanel>
            </ui:Card>

            <ui:Button Content="Secondary Button" 
                       Appearance="Secondary"
                       HorizontalAlignment="Center"
                       Margin="0,10,0,0"
                       Width="160"/>
        </StackPanel>
    </Grid>
</ui:FluentWindow>
```

### 5. Update `MainWindow.xaml.cs`

```csharp
using Wpf.Ui.Appearance;

namespace ModernUI
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ApplicationThemeManager.Apply(this);
        }
    }
}
```

---

## Run the Application

```bash
dotnet run
```

---

## Project Structure

```
ModernUI/
├── App.xaml
├── App.xaml.cs
├── MainWindow.xaml
├── MainWindow.xaml.cs
├── ModernUI.csproj
└── README.md
```

---

## Useful Links

- [WPF-UI GitHub](https://github.com/lepoco/wpfui)
- [WPF-UI Documentation](https://wpfui.lepo.co/)
- [NuGet Package](https://www.nuget.org/packages/WPF-UI/)

---

## License

This project is open source and available under the [MIT License](LICENSE).
```

---

### কিভাবে ব্যবহার করবেন:

1. প্রজেক্ট ফোল্ডারে `README.md` নামে একটি নতুন ফাইল তৈরি করুন।
2. উপরের সম্পূর্ণ কোড কপি করে পেস্ট করুন।
3. GitHub-এ পুশ করুন।

চাইলে আমি আরও সেকশন যোগ করতে পারি (যেমন: Dark/Light Theme Switch, NavigationView Example, Screenshot ইত্যাদি)। বলুন কী যোগ করতে চান।

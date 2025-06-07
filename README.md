# HelloWPF

A minimal WPF (Windows Presentation Foundation) application in C# demonstrating basic UI, code-behind, and MVVM concepts.

## Table of Contents

* [Description](#description)
* [Prerequisites](#prerequisites)
* [Setup](#setup)
* [Building and Running](#building-and-running)
* [Project Structure](#project-structure)
* [Troubleshooting](#troubleshooting)
* [Resources](#resources)

## Description

`HelloWPF` is a starter WPF application showcasing:

* A simple XAML-defined UI
* Event handling in code-behind
* Basic MVVM wiring (ViewModel, data binding, and commands)

## Prerequisites

* Windows 10 or later
* [.NET 6.0 SDK](https://dotnet.microsoft.com/download) or newer
* Visual Studio 2022 (or later) with the **.NET desktop development** workload

## Setup

1. **Clone the repository**

   ```bash
   git clone https://github.com/yourusername/HelloWPF.git
   cd HelloWPF
   ```
2. **Open the Solution**

   * Double-click `HelloWPF.sln` or open it via **File → Open → Project/Solution** in Visual Studio.

## Building and Running

* In Visual Studio, press **F5** or click **Start** to build and launch the app.
* You should see a window with a **Click Me!** button. Clicking it displays a **Hello, WPF!** message box.

## Project Structure

```
HelloWPF/             # Solution folder
├─ HelloWPF/          # WPF application project
│  ├─ App.xaml         # Application definition
│  ├─ App.xaml.cs      # Application startup logic
│  ├─ MainWindow.xaml  # Main window layout (UI)
│  ├─ MainWindow.xaml.cs # Code-behind for MainWindow
│  └─ ViewModels/      # (Optional) ViewModel classes for MVVM
│     └─ MainViewModel.cs
└─ HelloWPF.sln        # Visual Studio solution file
```

## Troubleshooting

* **`The name 'InitializeComponent' does not exist in the current context`**

  * Verify the `x:Class` in **MainWindow\.xaml** matches the namespace and class name in **MainWindow\.xaml.cs**.
  * Ensure **MainWindow\.xaml** Build Action is set to **Page** (right-click → Properties).
  * Clean the solution (**Build → Clean Solution**) and then rebuild (**Build → Rebuild Solution**).

* Other common issues:

  * Missing `.NET SDK` installation.
  * Mismatched target frameworks between projects.

## Resources

* [WPF .NET Documentation](https://docs.microsoft.com/dotnet/desktop/wPF/)
* [MVVM Pattern Overview](https://docs.microsoft.com/azure/architecture/patterns/mvvm)
* [Tim Corey WPF Tutorials](https://www.youtube.com/c/IAmTimCorey)

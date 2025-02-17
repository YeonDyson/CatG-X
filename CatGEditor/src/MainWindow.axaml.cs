using System;
using System.IO;
using Avalonia.Controls;
using Avalonia.Controls.Chrome;
using Avalonia.Platform;
using CatG.Core.Containers;
using CatG.Core.Serialization;

namespace CatGEditor;

public partial class MainWindow: Window {
    public MainWindow() {
        InitializeComponent();

        var json = File.ReadAllText(@"C:\Users\a2006\Documents\project\Mirrozed\Mirrozed\test.cntr");
        Serializer.Deserialize<ContainerCObject>(json);
    }
}
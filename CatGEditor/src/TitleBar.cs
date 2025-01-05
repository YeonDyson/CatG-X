using Avalonia.Controls;
using Avalonia.Media;

namespace CatGEditor;

public class TitleBar: DockPanel {
    public TitleBar() {
        this.Background = Brushes.DarkGray;
        this.Height = 40;
    }
}
using Godot;
using GodotUtils.Debugging;

internal partial class Autoload : Node
{
    VisualizeAutoload _visualizeAutoload;

    public override void _Ready()
    {
        _visualizeAutoload = new VisualizeAutoload();
    }

    public override void _Process(double delta)
    {
        _visualizeAutoload.Update();
    }

    public override void _ExitTree()
    {
        _visualizeAutoload.Dispose();
    }
}

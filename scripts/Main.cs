using Godot;
using System;

public class Main : Node
{
    private Example _scene;
    
    public override void _Ready()
    {
        var example = ResourceLoader.Load("res://scenes/Example.tscn") as PackedScene;
        _scene = example?.Instance() as Example;
        _scene?.UpdateText("My Text");
        _scene?.MyLabel.SetPosition(new Vector2(100, 100));
//        _scene.UpdateAlternateText("Hi"); //works if you uncomment... stupid
        AddChild(_scene);
    }

}

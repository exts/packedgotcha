using Godot;
using System;

public class Example : Node
{
    public Label MyLabel = new Label();
    
    public override void _Ready()
    {
        var label = GetNode("MyLabelText") as Label;
        if(label != null)
        {
            MyLabel = label;
        }
    }

    public void UpdateText(string str)
    {
        MyLabel.Text = str;
    }

    public void UpdateAlternateText(string str)
    {
        var label = GetNode("MyLabelText") as Label;
        if(label != null)
        {
            label.Text = str;
        }
    }
}

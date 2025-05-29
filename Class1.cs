using Roblox__Editor_SDK___Version_1._0;
using Roblox__Editor_SDK___Version_1._0.Interfaces;
using System.Windows.Forms;
public class HelloPlugin : IPlugin
{
    public string Name => "Hello World";
    public string Description => "Displays a test message.";
    public string Version => "1.0";

    public void Execute(IEditorContext context)
    {
        MessageBox.Show("Hello from HelloPlugin!");
    }
}

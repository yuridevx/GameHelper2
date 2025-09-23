namespace GameHelper.RenderProviders;

using RemoteObjects;
using Rendering;

public class GameStateProvider : RenderProvider<GameStates>
{
    protected override void Render(GameStates obj)
    {
        obj.ToImGui();
    }
}
#pragma checksum "C:\Users\Isomorphism\Documents\Repos\DungeonRpg\DungeonRpg\Pages\Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d6d051f1c72f0296734a2170987a36a3bfb9cf8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DungeonRpg.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Isomorphism\Documents\Repos\DungeonRpg\DungeonRpg\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Isomorphism\Documents\Repos\DungeonRpg\DungeonRpg\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Isomorphism\Documents\Repos\DungeonRpg\DungeonRpg\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Isomorphism\Documents\Repos\DungeonRpg\DungeonRpg\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Isomorphism\Documents\Repos\DungeonRpg\DungeonRpg\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Isomorphism\Documents\Repos\DungeonRpg\DungeonRpg\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Isomorphism\Documents\Repos\DungeonRpg\DungeonRpg\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Isomorphism\Documents\Repos\DungeonRpg\DungeonRpg\_Imports.razor"
using DungeonRpg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Isomorphism\Documents\Repos\DungeonRpg\DungeonRpg\_Imports.razor"
using DungeonRpg.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Isomorphism\Documents\Repos\DungeonRpg\DungeonRpg\Pages\Editor.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Isomorphism\Documents\Repos\DungeonRpg\DungeonRpg\Pages\Editor.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editor")]
    public partial class Editor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 315 "C:\Users\Isomorphism\Documents\Repos\DungeonRpg\DungeonRpg\Pages\Editor.razor"
       
    private Map Map { get; set; }
    private enum DrawMode { Pen, Line, Rectangle, Fill, Copy, Remove };
    private DrawMode Mode { get; set; }
    private int SelectedTileIndex = 951;
    private Timer AutoSaveTimer;
    private bool EnableAutoSave = true;
    private int Layer = 0;
    private (int X, int Y) Position = (0, 0);
    private DateTime LastSaveTime = DateTime.MinValue;
    private Timer UpdateTimer;

    protected override void OnInitialized()
    {
        AutoSaveTimer = new Timer();
        AutoSaveTimer.Interval = 1000 * 60;
        AutoSaveTimer.Elapsed += AutoSave;
        AutoSaveTimer.AutoReset = true;
        AutoSaveTimer.Start();
        UpdateTimer = new Timer();
        UpdateTimer.Interval = 200;
        UpdateTimer.AutoReset = true;
        UpdateTimer.Elapsed += UpdateTimerElapsed;
        UpdateTimer.Start();
        base.OnInitialized();
    }

    private void UpdateTimerElapsed(object sender, EventArgs args)
    {
        InvokeAsync(StateHasChanged);
    }

    void OnTileChanged(int index)
    {
        // Called from child component, so we need to notify 
        // the parent that the state has changed.
        SelectedTileIndex = index;
        StateHasChanged();
    }

    private void Save()
    {
        mapService.Save();
        itemService.Save();
        npcService.Save();
        enemyService.Save();
        playerService.Save();
        LastSaveTime = DateTime.Now;
    }

    private void OpenMap(Map map)
    {
        Map = map;
    }

    private void SetMode(DrawMode mode)
    {
        Mode = mode;
    }

    private void SetLayer(int layer)
    {
        Layer = layer;
    }

    private void AutoSave(object sender, EventArgs args)
    {
        if(EnableAutoSave)
        {
            Save();
        }
    }

    private void KeyboardHandler(KeyboardEventArgs args)
    {
        if(args.CtrlKey && args.Key == "s")
        {
            Save();
        }
    }

    private void Click((int x, int y) position)
    {
        switch(Mode)
        {
            case DrawMode.Pen:
                Map[Layer, position.x, position.y] = SelectedTileIndex;
                break;
            case DrawMode.Remove:
                Map[Layer, position.x, position.y] = 0;
                break;
            case DrawMode.Copy:
                SelectedTileIndex = Map[Layer, position.x, position.y];
                Mode = DrawMode.Pen;
                break;
            case DrawMode.Fill:
                Map.FloorFill(Layer, position.x, position.y, SelectedTileIndex);
                break;
        }
    }

    private void Move(int x, int y)
    {
        Position.X += x;
        Position.Y += y;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PlayerService playerService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EnemyService enemyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NpcService npcService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ItemService itemService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ComponentService componentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MapService mapService { get; set; }
    }
}
#pragma warning restore 1591

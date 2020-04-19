#pragma checksum "C:\Users\Isomorphism\Documents\Repos\DungeonRpg\DungeonRpg\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9577bc2aab91ad143cf3ec76b2d8ac697236f78f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 241 "C:\Users\Isomorphism\Documents\Repos\DungeonRpg\DungeonRpg\Pages\Index.razor"
 
    private int currentId = 0;
    private List<WorldObject> WorldObjects = new List<WorldObject>();
    private string Message { get; set; }
    private List<string> Output { get; set; } = new List<string>();
    private bool CanMove((int x, int y) position)
    {
        var manhattanDistance = Math.Abs(8 - position.x) + Math.Abs(8 - position.y);
        return manhattanDistance != 0 && manhattanDistance < 3;
    }

    protected override void OnInitialized()
    {
        var shrine = new WorldObject
        {
            Position = (5, 5),
            TileId = 2412,
            Name = "Shrine of Health"
        };

        WorldObjects.Add(shrine);

        var character = new WorldObject
        {
            Position = (8, 8),
            TileId = 1088,
            Name = "Player"
        };

        WorldObjects.Add(character);

        var armor = new WorldObject
        {
            Position = (8, 8),
            TileId = 981
        };

        WorldObjects.Add(armor);
    }

    private void MoveTo(int x, int y)
    {
        var player = WorldObjects.First(wo => wo.Name == "Player");
        player.Position = (x, y);
    }

    private void Command(KeyboardEventArgs args)
    {
        if (args.Key == "Enter")
        {
            Output.Add(Message);
            Message = String.Empty;
        }
    }

    private class WorldObject
    {
        public (int X, int Y) Position;
        public int TileId;
        public string Name;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

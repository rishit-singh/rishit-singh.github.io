using System.Collections;
using System.Threading.Tasks.Dataflow;
using Microsoft.AspNetCore.Components;

namespace portfolio;

public class Component : ComponentBase
{
    [Parameter] public RenderFragment ChildContent { get; set; }

    [Parameter] 
    public string Class { get; set; }
    
    [Parameter] 
    public string ID { get; set; }

    public CSSProperties Style;
    
    public virtual string ToCssString()
    {
        return null;
    }

    public Component()
    {
    }
}

public partial class Container : ComponentBase
{
    [Parameter] public string ID { get; set; }

    [Parameter] public string Class { get; set; }

    [Parameter] public string CSS { get; set; }

    protected CSSProperties Style;
    
    public string ToCssString()
    {
        return $"{this.Style.ToString()}{this.CSS}";
    }

    public Container()
    {
        this.Style = new CSSProperties();
    }
}

public partial class Grid : ComponentBase //Component
{
    [Parameter] 
    public string Class { get; set; }

    [Parameter] 
    public string ID { get; set; }

    [Parameter] 
    public uint Rows { get; set; }

    [Parameter]
    public uint Columns { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }
    
    public CSSProperties Style { get; set; }

    public string ToCssString()
    {
        return this.Style.ToString();
    }

    public string Initialize()
    {
        this.Style = new CSSProperties();
        
        this.Style.SetProperty("display", "grid");
        this.Style.SetProperty("grid-template-rows", Convert.ToString(this.Rows));
        this.Style.SetProperty("grid-template-columns", Convert.ToString(this.Columns));

        return null;
    } 
    
    public Grid() : base()
    {
    }
}




using Microsoft.AspNetCore.Components;

namespace portfolio
{
    public partial class TextBlock : ComponentBase 
    {
        [Parameter] public string Content { get; set; }

        [Parameter] public Color FontColor { get; set; }

        [Parameter] public bool Visible { get; set; }
        
        [Parameter]
        public RenderFragment ChildContent { get; set; }


        public CSSProperties Style; 
        
        public string ToCssString()
        {
            return $"color: {ColorManager.Colors[(int)this.FontColor].ToString()}";
        }

        public TextBlock() : base()
        {
        }
    }
}
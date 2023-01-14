using Microsoft.AspNetCore.Components;

namespace portfolio
{
    public partial class GridItem : ComponentBase
    {
        [Parameter] 
        public string Class { get; set; }
        
        [Parameter] 
        public string  ID { get; set; }

        [Parameter] 
        public uint RowIndex { get; set; }

        [Parameter] 
        public uint ColumnIndex { get; set; }

        [Parameter] 
        public uint RowSpan { get { return 1; } set { } }

        [Parameter] 
        public uint ColumnSpan { get { return 1; } set { } }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter] public string CSS { get; set; }

        
        protected CSSProperties Style;

        public string ToCssString()
        {
            return  $"{this.Style.ToString()}{this.CSS}";
        }

        public string Initialize()
        {
            this.Style = new CSSProperties();
            this.Style.SetProperty("grid-row-start", Convert.ToString(this.RowIndex + 1));
            this.Style.SetProperty("grid-row-end", Convert.ToString(this.RowIndex + 1 + this.RowSpan));
            
            this.Style.SetProperty("grid-column-start", Convert.ToString(this.ColumnIndex + 1));
            this.Style.SetProperty("grid-column-end", Convert.ToString(this.ColumnIndex + 1 + this.ColumnSpan));

            return null;
        }
    }
}
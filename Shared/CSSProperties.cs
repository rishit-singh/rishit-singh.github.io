using System.Collections;
using System.Collections.Generic;

namespace portfolio;

public class CSSProperties
{
    protected Hashtable Map;

    public void SetProperty(string key, string value)
    {
        if (this.Map.ContainsKey(key))
        {
            this.Map[key] = value;
            
            return;
        }
        
        this.Map.Add(key, value);
    }

    public override string ToString()
    {
        string cssString = null;

        foreach (string key in this.Map.Keys)
            cssString += $"{key}: {this.Map[key]};";
        
        return cssString;
    }

    public CSSProperties()
    {
        this.Map = new Hashtable();
    }
}


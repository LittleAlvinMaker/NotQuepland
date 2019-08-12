using System;
using System.ComponentModel;

public class Region
{
    public string AreaURL { get; set; }
[DefaultValue("No Name Region")]
	  public string Name { get; set; }
[DefaultValue("Whoops. The dev forgot to add a region description here.")]
    public string Description { get; set; }
[DefaultValue(new Zone[])]
    public string Zones { get; set; }

}

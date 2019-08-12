using System;
using System.ComponentModel;

public class Zone
{
    public string AreaURL { get; set; }
[DefaultValue("No Name Zone")]
	  public string Name { get; set; }
[DefaultValue("Whoops. The dev forgot to add a zone description here.")]
    public string Description { get; set; }
[DefaultValue(new Area[])]
    public string Areas { get; set; }

}

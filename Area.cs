using System;
using System.ComponentModel;

public class Area
{
// Immutable information
    public string AreaURL { get; set; }
[DefaultValue("No Name")]
	  public string Name { get; set; }
[DefaultValue("Whoops. The dev forgot to add a description here.")]
    public string Description { get; set; }
[DefaultValue("oi oi-question-mark")]
    public string Icon { get; set; }
    public string[] Actions { get; set; }
    public string[] UnlockableAreas { get; set; }
    public string AreaToUnlockOnArrival { get; set; }
    public string[] Buildings { get; set; }
    public int[] NPCIDs { get; set; }
    public int[] MonsterIDs { get; set; }
    public int[] HuntingIDs { get; set; }
    public string ActionRequiredForAccess { get; set; }
    public string RedirectAreaURL { get; set; }
    public string AccessibleRegions { get; set; }
    public bool HasDojo { get; set; }
    public int DojoID { get; set; }
    [DefaultValue(0)]
        public int ID { get; set; }

// Mutable information
[DefaultValue(false)]
    public bool IsUnlocked { get; set; }
[DefaultValue(true)]
    public bool Hidden { get; set; }  // To be changed to IsHidden
[DefaultValue(false)]
    public bool IsMarked { get; set; }

// For regions/zones only (deprecated)
    public string Region { get; set; }
    public string[] Children { get; set; }

    public bool IsRegion { get; set; }
    public bool IsShowingChildren { get; set; }

}

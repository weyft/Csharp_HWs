using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

public class GameCharacter
{
    public string Name { get; set; }
    public int Level { get; set; }
    public double Health { get; set; }
    public string[] Inventory { get; set; }
}
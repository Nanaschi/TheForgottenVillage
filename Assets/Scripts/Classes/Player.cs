using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : Entity //this gives access to the Entity script
{
    public string[] inventory; //all these properties are the difference between all entities and the player
    public string[] skills;
    public int money;
}

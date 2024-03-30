using UnityEngine;

public class Dragon : Person
{
    public Dragon(string NameID, int HP) : base(NameID, HP)
    {
    }
    
    public override void TakeDamage(int damageValue)
    {
        Debug.Log("I, the mighty dragon, have lost: " + damageValue + " hit points from a hunter's shot." + " I have: health " + (DataHP - damageValue));
        DataHP -= damageValue;
    }
}


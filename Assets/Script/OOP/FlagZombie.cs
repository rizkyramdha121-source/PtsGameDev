using UnityEngine;

public class FlagZombie : Enemy
{
    public bool flag = true;

    public override void serang()
    {
        Debug.Log("FlagZombie nyokot arghh");
    }
}
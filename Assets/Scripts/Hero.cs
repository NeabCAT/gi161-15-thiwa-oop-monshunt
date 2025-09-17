using UnityEngine;

public class Hero : Charactor
{

    private int gold;
    public int Gold 
    {
        get { return gold; }
        set { if (value > 999) { gold = 999; }
            else if (value <= 0) gold = 0;
            else { gold = value; }  
            }  
    }

    //Constructor (For create object)
    /*public void Init(string newName, int newHealth, int newAttackPower)
    {
        base.Init(newName, newHealth, newAttackPower);
        Gold = 0;
    }*/

    public override void Init(string newName, int newHealth, int newAttackPower)//Same Name Same Parameter but Difference Inside (Medthod Overriding)
    {
        base.Init(newName, newHealth, newAttackPower);
        Gold = 0;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"{Name} Current Gold : {Gold} , IsAlive {IsAlive()} ");
    }

    //Initialize


    public void EarnGold(int lootGold)
    {
        Gold += lootGold;
        Debug.Log($" {Name} get {Gold} Gold.");
    }

}
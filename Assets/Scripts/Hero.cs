using UnityEngine;

class Hero
{
    //Attribute
   private string name;
   public string Name 
    { 
        get { return name; } 
        set { if (string.IsNullOrEmpty(value)) name = "Unknown Hero";
              else {name = value;}
        }
    }

   private int health;
   public int Health 
    {
        get { return health; }
        set { if ( value >= 0 ) health = value;
              else health = 0;
            } 
    }

    private int gold;
    public int Gold 
    {
        get { return gold; }
        set { if (value > 999) { gold = 999; }
            else if (value <= 0) gold = 0;
            else { gold = value; }  
            }  
    }

    public int AttackPower { get; private set; }

    //Constructor (For create object)
    public Hero(string newName, int newHealth, int newAttackPower)
    {
        Name = newName;
        Health = newHealth;
        AttackPower = newAttackPower;
        Gold = 0;
    }

    public void ShowStat()
    {
        Debug.Log($"Hero Name: {Name} , Health: {Health} , Gold: {Gold}");
    }

    public void TakeDamage(int damageValue)
    {
        Health -= damageValue;
    }

    public void Attack(Monsters target)
    {
        Debug.Log($"{Name} attacks {target.Name} for {AttackPower} damage!");
        target.TakeDamage(AttackPower);
    }

    public void EarnGold(int amount)
    {
        if (amount > 0) 
        { 
             Gold += amount;
        }
    }

    public bool IsAlive()
    {
        return health > 0; 
    }


}
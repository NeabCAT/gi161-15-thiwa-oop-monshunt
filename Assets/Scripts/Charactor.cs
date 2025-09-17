using UnityEngine;

public abstract class Charactor : MonoBehaviour //Abstract can't use to construct obj
{
    //Attribute
    private string name;
    public string Name
    {
        get => name;
        set => name = string.IsNullOrEmpty(value) ? "Unknown" : value;
    }

    private int health;
    public int Health
    {
        get { return health; }
        set
        {
            if (value >= 0) health = value;
            else health = 0;
        }
    }

    private int attackPower;

    public int AttackPower { get => attackPower; set => attackPower = value; }


    //Constructor (For create object)
    public virtual void Init(string newName, int newHealth, int newAttackPower)
    {
        Name = newName;
        Health = newHealth;
        AttackPower = newAttackPower;
    }

    //Initialize

    public virtual void ShowStat()
    {
        Debug.Log($"Hero Name: {Name} , Health: {Health} , AttackPower : {AttackPower}");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{Name} Take {damage} Damage!, Current Health: {Health}");
    }

    public void Attack(Monsters target)
    {
        Debug.Log($"{Name} attacks {target.Name} for {AttackPower} damage!");
        target.TakeDamage(AttackPower);
    }

    public bool IsAlive()
    {
        return (Health > 0);
    }



}

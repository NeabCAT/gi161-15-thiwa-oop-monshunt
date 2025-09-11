class Monsters
{
    //Attribute
    public string name;
    public int health;
    public bool monsterDefeated;

    //Constructor (For create object)
    public Monsters(string newName, int newHealth)
    {
        name = newName;
        health = newHealth;
        monsterDefeated = false;
    }


}
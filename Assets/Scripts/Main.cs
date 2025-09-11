using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called once(ครั้งเดียว) before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hero hero = new Hero("Yasuo",50);

        Monsters monster1 = new Monsters("Orc", 25);
        Monsters monster2 = new Monsters("Goblin", 30);
        Monsters monster3 = new Monsters("Dragon", 35);

        //Console.WriteLine
        Debug.Log($"Hero Name: {hero.name} , Health: {hero.health} , Gold: {hero.gold}");
        Debug.Log($"Monster1: {monster1.name} , Health: {monster1.health}");
        Debug.Log($"Monster2: {monster2.name} , Health: {monster2.health}");
        Debug.Log($"Monster3: {monster3.name} , Health: {monster3.health}");
    }

 
}

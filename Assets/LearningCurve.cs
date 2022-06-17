using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character character = new Character();
        character.printing();
        Character nameCharacter = new Character("Kibibi");
        //Character hero2 = nameCharacter;
        //hero2.name = "clement";
        nameCharacter.printing();
        //hero2.printing();
        Weapon huntingBow = new Weapon("Hunting Bow", 150);
        Weapon huntingBow2 = huntingBow;
        huntingBow2.name = "this is copy";
        huntingBow2.damage = 50;
        huntingBow.printWeapons();
        //huntingBow2.printWeapons();
        Paladin knight = new Paladin("drako",huntingBow);
        knight.printing();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


public class Character
{
    public string name;
    public int exp = 0;

    public Character()
    {
        this.name = "not assigned";
    }

    public Character(string name)
    {
        this.name = name;
    }

    public virtual  void printing()
    {
        Debug.LogFormat("The name is {0} and exp is {1}", this.name, this.exp);
    }
}

public class Paladin : Character
{
    public Weapon weapon;
    public Paladin(string name,Weapon weapon) : base(name)
    {
        this.weapon = weapon;
    }

    public override void printing()
    {
        Debug.LogFormat("The name is {0},exp is {1},weapon name {2} and weapon damage {3}", this.name, this.exp, weapon.name, weapon.damage);
    }
}

public struct Weapon
{
    public string name;
    public int damage;


    public Weapon(string name,int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void printWeapons()
    {
        Debug.LogFormat("The name of weapon is {0} and the damage is {1}", this.name, this.damage);
    }
}
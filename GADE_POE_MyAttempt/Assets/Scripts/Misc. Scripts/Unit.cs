using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    private int health;
    private int attack;
    private string faction;
    

    public Unit(int Health, int Attack, string Faction)
    {
        health = Health;
        attack = Attack;
        faction = Faction;
    }

}

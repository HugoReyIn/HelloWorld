using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character
{
    private string name;
    private int healthPoints = 3;
    private int killed;
    private bool isDead;

    public character(string name)
    {
        this.Name = name;
        this.HealthPoints = HealthPoints;
        Debug.Log("Hola, soy " + this.Name + " y me quedan " + this.HealthPoints + " corazones de vida.");
    }

    ~character()
    {
        Debug.Log("Destroyed.");
    }

    public int HealthPoints { get => healthPoints; set => healthPoints = value; }

    public string Name { get => name; set => name = value; }
}

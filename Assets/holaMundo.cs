using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holaMundo : MonoBehaviour
{
    Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola Mundo!");
        enemy = new Enemy("Joker");
        Player player = new Player("Batman");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Soy el enemigo " + enemy.Name + " y tengo " + enemy.HealthPoints + " de vida");
    }
}

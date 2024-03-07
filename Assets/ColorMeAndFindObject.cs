using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMeAndFindObject : MonoBehaviour
{
    public GameObject[] gameObjects;
    public Color color;
    public bool filterByName;
    public string nameToFind;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObjects = GameObject.FindGameObjectsWithTag(nameToFind);
    }

    // Update is called once per frame
    void Update()
    {
        FilterByName();
    }

    void FilterByName()
    {
        if (filterByName == true)
        {
            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].GetComponent<Renderer>().material.color = color;
            }

        }
    }

}

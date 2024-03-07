using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        createCubeAndSetParent();
    }

    private void createCubeAndSetParent()
    {
        GameObject cubeChild = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubeChild.transform.SetParent(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Posicion x: " +  this.transform.position.x);
            Debug.Log("Posicion y: " + this.transform.position.y);
            Debug.Log("Posicion z: " + this.transform.position.z);
        }*/

        checkMovement();
        checkScale();
        checkRotation();
        
    }

    private void checkRotation()
    {
        transform.rotation *= Quaternion.Euler(0, 1 * speed, 0);
    }

    private void checkScale()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.localScale += Vector3.up * speed;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            transform.localScale += Vector3.down * speed;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            transform.localScale += Vector3.right * speed;
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            transform.localScale += Vector3.left * speed;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            transform.localScale += Vector3.forward * speed;
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            transform.localScale += Vector3.back * speed;
        }
    }

    private void checkMovement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position += Vector3.forward * speed;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position += Vector3.back * speed;
        }

    }

}

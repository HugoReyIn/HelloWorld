using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectTest : MonoBehaviour
{
    private Transform transform;
    private Material material;
    public GameObject CuboCubero;
    public GameObject CirculoCirano;
    public GameObject PastillaPaLaTos;
    public GameObject CilindroCilindri;

    // Start is called before the first frame update
    void Start()
    {
        CuboCubero = GameObject.Find("CuboCubero");
        CirculoCirano = GameObject.Find("CirculoCirano");
        CilindroCilindri = GameObject.Find("CilindroCilindri");
        PastillaPaLaTos = GameObject.Find("PastillaPaLaTos");
        transform = CuboCubero.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        logPosition();
    }

    private void logPosition()
    {
        Debug.LogFormat("La posicion del objeto es: {0}x", transform.localPosition.x);
        Debug.LogFormat("La posicion del objeto es: {0}y", transform.localPosition.y);
        Debug.LogFormat("La posicion del objeto es: {0}z", transform.localPosition.z);
    }
}

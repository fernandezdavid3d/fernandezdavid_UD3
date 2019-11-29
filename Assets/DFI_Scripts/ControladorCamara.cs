using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour
{
    public GameObject jugador;//objeto a perseguir
    private Vector3 posicionRelativa;

    // Start is called before the first frame update
    void Start()
    {
        posicionRelativa = transform.position - jugador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = jugador.transform.position + posicionRelativa;
    }
}

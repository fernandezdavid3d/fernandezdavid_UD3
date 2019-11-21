using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorDelJugador : MonoBehaviour
{
    //Almacena componente Rigidbody del personaje Jugador
    Rigidbody rb;
    public float velocidad;
    int contador;

    public Text marcador;
    public Text finJuego;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        ActualizaMarcador();
        finJuego.gameObject.SetActive(false);
    }

    public void FixedUpdate()
    {

        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
        rb.AddForce(movimiento*velocidad);
    }


    public void OnTriggerEnter(Collider other) //Collider es el objeto con el que ha colisionado
    {
        Destroy(other.gameObject);
        contador = contador + 1;
        ActualizaMarcador();
        if(contador>=5)
        {
            finJuego.gameObject.SetActive(true);
        }
    }

    void ActualizaMarcador()
    {
        marcador.text = "Puntos:" + contador;
    }
}
using UnityEngine;

public class ControlarObjeto : MonoBehaviour
{
    // En esta variable configuraremos la velocidad a la que se moverá el objeto
    public float Velocidad = 5.0F;

    private bool derecha = false;
    private bool izquierda = false;
    private bool arriba = false;
    private bool abajo = false;
    private bool aumentar = false;
    private bool disminuir = false;

    void Update()
    {
        if (derecha)
        {
            // Movemos el objeto hacia la derecha
            this.transform.Translate(Vector3.right * Time.deltaTime * Velocidad);
        }

        if (izquierda)
        {
            // Movemos el objeto hacia la izquierda
            this.transform.Translate(Vector3.left * Time.deltaTime * Velocidad);
        }

        if (arriba)
        {
            // Movemos el objeto hacia arriba
            this.transform.Translate(Vector3.up * Time.deltaTime * Velocidad);
        }

        if (abajo)
        {
            // Movemos el objeto hacia abajo
            this.transform.Translate(Vector3.down * Time.deltaTime * Velocidad);
        }

        if (aumentar)
        {
            // Aumentamos la escala del objeto
            this.transform.localScale = new Vector3(
                this.transform.localScale.x + 0.05F,
                this.transform.localScale.y + 0.05F,
                this.transform.localScale.z + 0.05F);
        }

        if (disminuir)
        {
            // Disminuimos la escala del objeto
            this.transform.localScale = new Vector3(
                this.transform.localScale.x - 0.05F,
                this.transform.localScale.y - 0.05F,
                this.transform.localScale.z - 0.05F);
        }
    }

    /******************** FUNCIONES PÚBLICAS ********************/

    public void MoverDerecha()
    {
        derecha = true;
    }

    public void MoverIzqda()
    {
        izquierda = true;
    }

    public void MoverArriba()
    {
        arriba = true;
    }

    public void MoverAbajo()
    {
        abajo = true;
    }

    public void Detener()
    {
        derecha = false;
        izquierda = false;
        arriba = false;
        abajo = false;
    }

    public void AumentarEscala()
    {
        aumentar = true;
    }

    public void DisminuirEscala()
    {
        disminuir = true;
    }

    public void DetenerEscala()
    {
        aumentar = false;
        disminuir = false;
    }
}
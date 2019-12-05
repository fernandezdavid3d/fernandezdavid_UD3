using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour
{

    public GameObject destino;
    private UnityEngine.AI.NavMeshAgent agenteDeNavegacion;

    // Use this for initialization
    void Start()
    {
        agenteDeNavegacion = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        agenteDeNavegacion.SetDestination(destino.transform.position);
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAnimManager : MonoBehaviour
{
    private Animator anim;
    public NavMeshAgent navMeshAgent;
    public bool isWalking;

    void Start ()
    {
        anim = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
          anim.SetFloat("PlayerVelocity", navMeshAgent.velocity.magnitude);
       
    }
    private void FixedUpdate()
    {

        //1. Comprueba que la tecla de Espacio ha sido pulsada
        if(Input.GetKeyDown(KeyCode.Space))
        {

            anim.SetFloat("salto", 1f);
        
        }
        else
        {
            //2. Escribe la sentencia que indica al componente Animator del personaje
            //que no debe ejecutar la animación de salto
            anim.SetFloat("salto", 0f);
        }
       
    }

  
}

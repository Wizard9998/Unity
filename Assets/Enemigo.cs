using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int vida, ataque;

    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void Destruir()
    {
        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Daño()
    {
        anim.SetTrigger("Dañado");
    }

}

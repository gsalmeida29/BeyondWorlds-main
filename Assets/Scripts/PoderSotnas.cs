using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public float velocidade = 10f;


public class PoderSotnas : MonoBehaviour
{
    // Start is called before the first frame update
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Atacar();
        }
    }

    void Atacar()
    {
        GameObject novoProjetil = Instantiate(
            projetil,
            pontoDeDisparo.position,
            Quaternion.identity
        );

        Rigidbody2D rb = novoProjetil.GetComponent<Rigidbody2D>();

        float direcao = transform.localScale.x;

        rb.linearVelocity = new Vector2(
            direcao * velocidade,
            0
        );
    }
}

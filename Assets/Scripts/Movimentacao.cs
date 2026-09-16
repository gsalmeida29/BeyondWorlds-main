using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    [Header("Configurações de Movimento")]
    public float velocidade = 5.0f;

    private Rigidbody rb;
    private float inputX;
    private float inputZ;

    // Start is called before the first frame update
    void Start()
    {
        // Pega a referência do Rigidbody anexado ao personagem
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Captura as entradas das teclas (WASD ou Setas) a cada frame
        inputX = Input.GetAxisRaw("Horizontal");
        inputZ = Input.GetAxisRaw("Vertical");
    }

    // FixedUpdate é usado para cálculos de física
    void FixedUpdate()
    {
        Mover();
    }

    void Mover()
    {
        // Cria a direção de movimento com base nos eixos X e Z
        Vector3 direcao = new Vector3(inputX, 0f, inputZ).normalized;

        // Aplica a velocidade mantendo a força da gravidade no eixo Y
        Vector3 velocidadeFinal = direcao * velocidade;
        rb.velocity = new Vector3(velocidadeFinal.x, rb.velocity.y, velocidadeFinal.z);
    }
}
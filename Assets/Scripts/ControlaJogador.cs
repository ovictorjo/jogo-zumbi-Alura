using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogador : MonoBehaviour
{
    public float velocidade = 20;
  

    void Update()
    {
        float eixoX = Input.GetAxis("Horizontal");
        float eixoZ = Input.GetAxis("Vertical");


        Vector3 direcao = new Vector3(eixoX, 0, eixoZ);
        
        transform.Translate(direcao * (velocidade * Time.deltaTime));

        
       GetComponent<Animator>().SetBool("Movendo", direcao != Vector3.zero);
        
    }
}

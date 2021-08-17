using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogador : MonoBehaviour
{
    public float velocidade = 15;
    private Animator _animator;

    // Update is called once per frame
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        float eixoX = Input.GetAxis("Horizontal");
        float eixoZ = Input.GetAxis("Vertical");


        Vector3 direcao = new Vector3(eixoX, 0, eixoZ);
        
        transform.Translate(direcao * (velocidade * Time.deltaTime));


        _animator.SetBool("Movendo", direcao != Vector3.zero);
    }
}

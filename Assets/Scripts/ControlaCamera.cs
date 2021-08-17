using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Jogador;
    private Vector3 distCompensar;
    
    void Start()
    {
        distCompensar = transform.position - Jogador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Jogador.transform.position + distCompensar;

    }
}

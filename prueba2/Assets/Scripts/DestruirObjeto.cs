using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirObjeto : MonoBehaviour
{
    public float limiteSuperior = 25.0f;
    public float limiteInferior = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > limiteSuperior)
        {
            Destroy(gameObject);
            Debug.Log("Estás jugando");
        }  
        else if (transform.position.z < limiteInferior)
        {
            Destroy(gameObject);
            Debug.Log("El juego ha terminado");
        }
    }
}

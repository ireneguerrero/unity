using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coche : MonoBehaviour
{
    public float velocidad = 20.0f;
    public float velocidadGiro = 5.0f;
    public float controlHorizontal;
    public float controlAvance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // controlar el coche con las flechas del teclado
        controlHorizontal = Input.GetAxis("Horizontal");
        controlAvance = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * controlAvance);
        transform.Translate(Vector3.right * Time.deltaTime * velocidadGiro * controlHorizontal);
    }
}

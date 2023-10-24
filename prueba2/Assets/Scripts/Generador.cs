using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject[] animalesPrefab;
    private float xposicion1 = 20.0f;
    private float xposicion2 = 20.0f;
    private float inicioGeneracion = 2.0f;
    private float retardoGeneracion = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarAleatorio", inicioGeneracion, retardoGeneracion);
    }

    // Update is called once per frame
    void GenerarAleatorio()
    {
        int a = Random.Range(0, animalesPrefab.Length);
        Vector3 PosicionGenerador = new Vector3(Random.Range(-xposicion1, xposicion2), 0, 20);
        Instantiate(animalesPrefab[a], PosicionGenerador, animalesPrefab[a].transform.rotation);
    }
}

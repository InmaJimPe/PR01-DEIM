using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    [SerializeField] string nombre;
    // Start is called before the first frame update
    void Start()
    {
       
        

    }
    void Saludos(string nombre)
    {

        print("saludos " + nombre);

    }
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            Saludos(nombre);

        }


    }

    




}



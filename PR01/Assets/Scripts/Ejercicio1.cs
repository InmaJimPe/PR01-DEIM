using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(x < 10) 
        {
            print("X es menos que 10");
            x++;

        }

        if(x == 10) 
        {
            print("Igual a 10");
            x = 11;
        }
    }
}

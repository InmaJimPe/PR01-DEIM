using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    int aleatorio = 0;
    [SerializeField] int numElegido;
    // Start is called before the first frame update
    void Start()
    {
        while(aleatorio != numElegido)
        {
            aleatorio = Random.Range(0, 10);
            print(aleatorio);


        }



    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
}

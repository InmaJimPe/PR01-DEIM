using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    int x = 10;
    // Start is called before the first frame update
    void Start()
    {
        while (x > 0)
        {
            print(x);
            x--;
            if (x == 0)
                print("es un cero");
            
        }
        for (x = 10; x >= 0; x -= 1)
        {
            print(x);
            if (x == 0)
                print("es un cerapio");
            if (x == 1)
                print("vamos por el uno");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
}

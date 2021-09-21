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

        }
        for (x = 10; x >= 0; x -= 1)
        {
            print(x);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
}

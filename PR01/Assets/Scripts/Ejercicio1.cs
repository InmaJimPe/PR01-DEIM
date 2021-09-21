using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    [SerializeField] int num1 = 10;
    [SerializeField] float dec1 = 5.9f;
    [SerializeField] bool bool1 = false;
    [SerializeField] string text1 = "Hola mundo";
    // Start is called before the first frame update
    void Start()
    {
        print(num1 = 9);
        print(text1 = "Adios");
        print(bool1 = true);
        print(dec1 = 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

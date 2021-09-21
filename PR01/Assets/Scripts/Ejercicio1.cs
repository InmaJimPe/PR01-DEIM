using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    [SerializeField] int num1 = 10;
    [SerializeField] float dec1 = 5.9f;
    bool bool1 = false;
    string text1 = "Hola mundo";
    float multiplicar;
    // Start is called before the first frame update
    void Start()
    {
        float resultado;
        resultado = num1 + dec1;
        print(resultado);
        multiplicar = num1 * dec1;
        print(multiplicar);
        print("resultado" + multiplicar);
        print("Esta vivo" + bool1);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

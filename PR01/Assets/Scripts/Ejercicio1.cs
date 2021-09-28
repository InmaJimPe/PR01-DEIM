using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    [SerializeField] float num1;
    [SerializeField] float num2;
    [SerializeField] string op;

    bool par = true;
    // Start is called before the first frame update
    void Start()
    {
        Calcular(num1, num2, op);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Calcular(num1, num2, op);

        }
    }

    void Calcular(float num1, float num2, string op)
    {
        float resultado = 0f;
        if (op == "dividir")
        {

            resultado = num1 / num2;

        }
        else if (op == "multiplicar")
        {

            resultado = num1 * num2;

        }
        else if (op == "sumar")
        {

            resultado = num1 + num2;

        }
        else if (op == "restar")
        {

            resultado = num1 - num2;

        }
        print(resultado);
        resultado = resultado%2;

        if(resultado == 0)
        {
            print("Par ");
            par = true;
        }
        else
        {
            print("Impar ");
            par = false;
        }



    }






}



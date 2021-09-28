using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    

    
    // Start is called before the first frame update
    void Start()
    {


        StartCoroutine("Reloj");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Reloj()
    {

        int segundos = 0;
        int minutos = 0;
        int horas = 0;
        string textoreloj;

        for (int n = 0; ; n++)
        {

            segundos++;

            if (segundos > 59)
            {
                minutos++;
                segundos = 0;


            }

            if (minutos > 59)
            {
                horas++;
                minutos = 0;


            }

            textoreloj = horas.ToString("D2") + ":" + minutos.ToString("D2") + ":" + segundos.ToString("D2");

            print(textoreloj);

            yield return new WaitForSeconds(1f); 

            







        }


    }





}









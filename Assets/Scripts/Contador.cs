using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public Text cronometro;
    public float tiempo = 50f;
    private float tiempo2 = 3f;
    private bool presionoBoton = false;
    private bool estaCorriendo = false;
    private int contador = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t"))// cuando oprima la t se pausa el tiempo por 3segundo con un limite de tres intentos 
        {
            if (estaCorriendo != true)
            {
                contador++;
                if (contador <= 3)
                {
                    presionoBoton = true;
                    tiempo2 = 3f;
                    estaCorriendo = true;
                }
                else
                {
                    Debug.Log("Limite de intentos");
                }
            }
        }
        if (tiempo <= 0)
        {
            tiempo = 0;
        }
        else
        {
            if (presionoBoton == true)
            {
                if (tiempo2 <= 0)
                {
                    presionoBoton = false;
                    estaCorriendo = false;
                    tiempo2 = 0;
                }
                else
                {
                    tiempo2 = tiempo2 - Time.deltaTime;
                    tiempo = tiempo - Time.deltaTime / 2; //dividir el tiempo en la mitad
                }
            }
            else
            {
                tiempo = tiempo - Time.deltaTime;
            }


        }
        cronometro.text = "Tiempo : " + tiempo.ToString("f0");// Cronometro se pone F0 para que no sean numero enteros y no decimales 
    }
    }
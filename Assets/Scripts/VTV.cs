using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VTV : MonoBehaviour
{
    // Start is called before the first frame update
    public string patente;
    public int modelo;
    public int kmRecorridos;
    public int vencimientoActual;
    public int HCppm;

    int anioActual = 2025;
    void Start()
    {
        if( (patente == ""))
        {
            Debug.Log("VTV no aprobada: Ingresa un patente valida");
            return;
        }
        if(modelo < 1900 || modelo > anioActual)
        {
            Debug.Log("VTV no aprobada: El año de fabricacion es menor a 1900 o mayor al año actual");
            return;
        }
        if (kmRecorridos < 0)
        {
            Debug.Log("VTV no aprobada: Los kilometros recorridos deben ser mayor o iguales a cero.");
            return;
        }
        if (vencimientoActual >= anioActual || vencimientoActual <= modelo)
        {
            Debug.Log("VTV no aprobada: El vencimiento debe ser menor que el año actual y mayor que el año de fabricación.");
            return;
        }

        if((HCppm < 5))
        {
            Debug.Log("VTV no aprobada: Los hidrorcarburos partículas por millón son menores que el minimo (5)");
            return;
        }
        if (HCppm > 100)
        {
            Debug.Log("VTV no aprobada: Los hidrorcarburos partículas por millón superan el maximo (100)");
            return;
        }

        int promedioKmRecorridos = kmRecorridos / (anioActual - modelo);
        if (promedioKmRecorridos <= 10000)
        {
            Debug.Log("VTV aprobada por 2 años");
        }
        else
        {
            Debug.Log("VTV aprobada por 1 año");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

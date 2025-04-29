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
        if( (patente == "") || (modelo < 1900 || modelo > anioActual ) || (kmRecorridos < 0) || (vencimientoActual >= anioActual || vencimientoActual <= modelo) || (HCppm < 5))
        {
            Debug.Log("VTV no aprobada");
            return;
        }
        if(HCppm > 100)
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

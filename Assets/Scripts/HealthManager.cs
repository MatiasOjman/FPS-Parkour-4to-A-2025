using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour  {

    public float vida = 100f;

    public bool UpdateLife(float puntos)
    {

        if (vida + puntos < 0)
        {
            return false;
        }
        else
        {
            vida = vida + puntos;
            return true;
        }
    }

}

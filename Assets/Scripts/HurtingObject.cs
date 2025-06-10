using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtingObject : MonoBehaviour
{
    public HealthManager healthManager;
    public float veneno; 
    // Start is called before the first frame update
    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    public bool UpdateLife(float life)
    {

        if (veneno + life < 0)
        {
            return false;
        }
        else
        {
            veneno += life;


            return true;
        }
    }
}

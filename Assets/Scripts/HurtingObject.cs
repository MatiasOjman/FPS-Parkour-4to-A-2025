using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtingObject : MonoBehaviour
{
    public HealthManager healthManager;
    public float veneno = -10f;
    // Start is called before the first frame update

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            healthManager.UpdateLife(veneno);
           
           
        } else
        {
            
        }
    }
}
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
    {
    public float vida;
    public HurtingObject hurtingObject;
    // Start is called before the first frame update
    void Start()
    {
        hurtingObject  = FindObjectOfType<HurtingObject>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {



        }
        if (hurtingObject.UpdateLife(-vida))
        {
            Destroy(gameObject);
        }
    }
   
}

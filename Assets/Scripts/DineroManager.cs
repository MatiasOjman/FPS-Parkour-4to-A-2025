using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManager : MonoBehaviour
{
    public float Playermoney;
    public UiManager uiManager;

    private void Start()
    {
        uiManager = FindObjectOfType<UiManager>();
    }
    public bool UpdateMoney(float amount)
    {
       
        if (Playermoney + amount < 0)
        {
            return false;
        }
        else
        {
            Playermoney += amount;
         
            return true;
        }
    }
   

}

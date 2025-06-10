using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{    public TextMeshProUGUI  TxtMoney;
    public DineroManager dineroManager;
    public HealthManager healthManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TxtMoney.text = dineroManager.Playermoney.ToString();
    }
}

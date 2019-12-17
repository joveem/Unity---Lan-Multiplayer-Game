using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;

public class player : NetworkBehaviour
{
    public float health = 100;
    public TextMeshProUGUI life_counter;


    // Start is called before the first frame update
    void Start()
    {
        if(isLocalPlayer){
            life_counter = GameObject.Find("health").GetComponent<TextMeshProUGUI>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isLocalPlayer){
            life_counter.text = health.ToString("F0");
        }
    }
}

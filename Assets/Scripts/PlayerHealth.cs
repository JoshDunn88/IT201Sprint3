using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class PlayerHealth : MonoBehaviour
{


    public int MaxHP = 100;
    public int PlayerHP;
    // public bool
    private FirstPersonController _fpcontroller;
    public TextMeshProUGUI healthDisplay;


    // Start is called before the first frame update
    void Start()
    {
        _fpcontroller = GetComponent<FirstPersonController>();
       /// healthDisplay 
        PlayerHP = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void takeFallDamage(){
        PlayerHP -= 20;
        healthDisplay.text = "HP: " + PlayerHP.ToString();
    }
}

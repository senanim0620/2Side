using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;


    public string Tags;

    public Canvas Keypad;
    public Canvas Interaction;
    public Canvas LastKeypad;
    public Canvas Inventory;

    public bool Interaction_canvas;

    //Singleton
    private void Awake()
    {
        if(instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        Keypad.enabled = false;
        Interaction.enabled = false;
        LastKeypad.enabled = false;
        Inventory.enabled = false;  
    }

}

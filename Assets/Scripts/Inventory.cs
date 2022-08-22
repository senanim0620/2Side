using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
 
    public Image[] Inventory_asset = new Image[4];
    //public bool[] Inventory_have = new bool[4];



    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i<4;i++)
        {
            Inventory_asset[i].enabled = false;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            
            if (UIManager.instance.Inventory.enabled)
                UIManager.instance.Inventory.enabled = false;
            else
                UIManager.instance.Inventory.enabled = true;
        }

        if (InteractionManager.instance.Inventory_bool[0])
        {
            
            Inventory_asset[0].enabled = true;
        }
    }
}

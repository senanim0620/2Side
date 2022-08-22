using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public static InteractionManager instance;

    public GameObject MedRack;
    public GameObject FirstKey;
    public GameObject FirstDoor;

    //여기에 있나 없나 볼 수 있음.
    public bool[] Inventory_bool = new bool[4];

    //Singleton
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }


}

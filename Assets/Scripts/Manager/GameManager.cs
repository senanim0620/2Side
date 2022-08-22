using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public string Tags;

    //public bool setactivecanvas = false;


    private void Awake()
    {
        if(instance == null)    
            instance = this;
        else
            Destroy(gameObject);

    }

}

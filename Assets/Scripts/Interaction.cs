using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public Inventory inventory;
    private bool MedRack_active;

    private void Start()
    {
        MedRack_active = false;
    }


    void Update()
    {
        // 상호작용 canvas 띄우기
        if (UIManager.instance.Interaction_canvas == true)
            UIManager.instance.Interaction.enabled = true;
        else
            UIManager.instance.Interaction.enabled = false;

        // E 키를 누르면 해당하는 캔버스 띄워줌
        if(Input.GetKeyDown(KeyCode.E))
        {
            Cursor.lockState = CursorLockMode.None;
            Tags();
        }


        if (Input.GetKey(KeyCode.Escape))
        {
            Door_closed();
            FinalDoor_closed();
        }
    }


    // 이제 캔버스 주루룩 만들면 여기에다가 추가하기만 하면 댄다.
    void Tags()
    {
        switch (GameManager.instance.Tags)
        {
            case "Door":
                Door_open();
                break;
            case "FinalDoor":
                FinalDoor_open();
                break;
            case "Bookshelf":
                  MedRack();
                  break;
            case "FirstKey":
                FirstKey();
                break;
            case "FirstKeyDoor":
                FirstKeyDoor();
                break;
            case "Plant":
                break;

            default:
                break;
        }
   
    }

    void Door_open()
    {
        UIManager.instance.Keypad.enabled = true;

    }

    void Door_closed()
    {
        UIManager.instance.Keypad.enabled = false;
    }

    void FinalDoor_open()
    {
        UIManager.instance.LastKeypad.enabled = true;
    }

    void FinalDoor_closed()
    {
        UIManager.instance.LastKeypad.enabled = false;
    }

    void MedRack()
    {
        if(!MedRack_active)
        {
            InteractionManager.instance.MedRack.GetComponent<Transform>().Rotate(new Vector3(0, -30, 0));
            MedRack_active =true;
        }
        else
        {
            InteractionManager.instance.MedRack.GetComponent<Transform>().Rotate(new Vector3(0, 30, 0));
            MedRack_active = false;
        }
    }

    void FirstKey()
    { 
        //E 누르면 없어지는 것처럼 보이고
        Destroy(InteractionManager.instance.FirstKey);
        InteractionManager.instance.Inventory_bool[0]= true;
        // 소지품에 들어오기
    }

    void FirstKeyDoor()
    {
        if (InteractionManager.instance.Inventory_bool[0])
        {
            InteractionManager.instance.FirstDoor.GetComponent<Transform>().Rotate(0, 40, 0);
        }
    }

    void SecondDoor()
    {

    }


}

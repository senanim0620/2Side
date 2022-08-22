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
        // ��ȣ�ۿ� canvas ����
        if (UIManager.instance.Interaction_canvas == true)
            UIManager.instance.Interaction.enabled = true;
        else
            UIManager.instance.Interaction.enabled = false;

        // E Ű�� ������ �ش��ϴ� ĵ���� �����
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


    // ���� ĵ���� �ַ�� ����� ���⿡�ٰ� �߰��ϱ⸸ �ϸ� ���.
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
        //E ������ �������� ��ó�� ���̰�
        Destroy(InteractionManager.instance.FirstKey);
        InteractionManager.instance.Inventory_bool[0]= true;
        // ����ǰ�� ������
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

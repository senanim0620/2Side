using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Password : MonoBehaviour
{
    public TextMeshProUGUI[] password = new TextMeshProUGUI[3];
    public Transform Door;



    public int[] array = new int[3];
    private int pivot;

    // Start is called before the first frame update
    void Start()
    {
        pivot = 0;
    }

    // Update is called once per frame
    void Update()
    {
      if(UIManager.instance.Keypad.enabled ==false)
        {
            password[0].text = "0";
            password[1].text = "0";
            password[2].text = "0";
            pivot = 0;
        }

    }

   public void OnClickZero()
    {
        if (pivot == 3 )
            return;

        password[pivot].text = "0"; 
        array[pivot] = 0;
        pivot++;
    }

    public void OnClickOne()
    {
        if (pivot == 3)
            return;

        password[pivot].text = "1";
        array[pivot] = 1;
        pivot++;

    }

    public void OnClickTwo()
    {
        if (pivot == 3)
            return;

        password[pivot].text = "2";
        array[pivot] = 2;
        pivot++;

    }

    public void OnClickThree()
    {
        if (pivot == 3)
            return;

        password[pivot].text = "3";
        array[pivot] = 3;
        pivot++;

    }

    public void OnClickFour()
    {
        if (pivot == 3)
            return;

        password[pivot].text = "4";
        array[pivot] = 4;
        pivot++;

    }

    public void OnClickFive()
    {
        if (pivot == 3)
            return;

        password[pivot].text = "5";
        array[pivot] = 5;   
        pivot++;

    }

    public void OnClickSix()
    {
        if (pivot == 3)
            return;

        password[pivot].text = "6";
        array[pivot] = 6;
        pivot++;

    }

    public void OnClickSeven()
    {
        if (pivot == 3)
            return;

        password[pivot].text = "7";
        array[pivot] = 7;
        pivot++;

    }

    public void OnClickEight()
    {
        if (pivot == 3)
            return;

        password[pivot].text = "8";
        array[pivot] = 8;
        pivot++;

    }

    public void OnClickNine()
    {
        if (pivot == 3)
            return;

        password[pivot].text = "9";
        array[pivot] = 9;
        pivot++;

    }

    public void OnClickEnter()
    {
        // 일단 엔터 누르면 꺼!
        UIManager.instance.Keypad.enabled = false;
        if (pivot==3 && (array[0]==7) && (array[1] == 4) && (array[2]==3))
        {
            UIManager.instance.Keypad.enabled = false;
            Debug.Log("철창문 정답");
            Door_open();
           
        }
    }


    public void Door_open()
    {
        Door.transform.Rotate(new Vector3(0, -50, 0));

    }

}


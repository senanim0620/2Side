using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LastPassword : MonoBehaviour
{
    public TextMeshProUGUI[] password = new TextMeshProUGUI[10];
    public Transform Door;

    public int[] array = new int[10];
    private int pivot;

    // Start is called before the first frame update
    void Start()
    {
        pivot = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (UIManager.instance.LastKeypad.enabled == false)
        {
            for(int i=0;i<10;i++)
            {
                password[i].text = "9";
            }

            pivot = 0;
        }

    }

    public void OnClickZero()
    {
        if (pivot == 11)
            return;

        password[pivot].text = "0";
        array[pivot] = 0;
        pivot++;
    }

    public void OnClickOne()
    {
        if (pivot == 11)
            return;

        password[pivot].text = "1";
        array[pivot] = 1;
        pivot++;

    }

    public void OnClickTwo()
    {
        if (pivot == 11)
            return;

        password[pivot].text = "2";
        array[pivot] = 2;
        pivot++;

    }

    public void OnClickThree()
    {
        if (pivot == 11)
            return;

        password[pivot].text = "3";
        array[pivot] = 3;
        pivot++;

    }

    public void OnClickFour()
    {
        if (pivot == 11)
            return;

        password[pivot].text = "4";
        array[pivot] = 4;
        pivot++;

    }

    public void OnClickFive()
    {
        if (pivot == 11)
            return;

        password[pivot].text = "5";
        array[pivot] = 5;
        pivot++;

    }

    public void OnClickSix()
    {
        if (pivot == 11)
            return;

        password[pivot].text = "6";
        array[pivot] = 6;
        pivot++;

    }

    public void OnClickSeven()
    {
        if (pivot == 11)
            return;

        password[pivot].text = "7";
        array[pivot] = 7;
        pivot++;

    }

    public void OnClickEight()
    {
        if (pivot == 11)
            return;

        password[pivot].text = "8";
        array[pivot] = 8;
        pivot++;

    }

    public void OnClickNine()
    {
        if (pivot == 11)
            return;

        password[pivot].text = "9";
        array[pivot] = 9;
        pivot++;

    }

    public void OnClickEnter()
    {
        // ÀÏ´Ü ¿£ÅÍ ´©¸£¸é ²¨!
        UIManager.instance.LastKeypad.enabled = false;
        if (pivot == 10 && (array[0] == 0) && (array[1] == 0) && (array[2] == 0) && (array[3]==0) && (array[4] == 2) && (array[5] == 0) && (array[6] == 2) && (array[7] == 1) && (array[8] == 2) && (array[9]==7))
        {
            Debug.Log("Å»Ãâ!");
            Open_door();

        }
    }

    void Open_door()
    {
        Door.transform.Rotate(new Vector3(0, 0, -50));
    }

}

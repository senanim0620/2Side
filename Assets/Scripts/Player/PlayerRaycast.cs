using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{

    RaycastHit hit;

    public float distance = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DrawLine();
    }

    void DrawLine()
    {

        Debug.DrawRay(transform.position, transform.forward * distance, Color.blue);

        if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
        {

            // 닿는게 있다면 상호작용 캔버스를 띄워주고
            UIManager.instance.Interaction_canvas = true;
            UIManager.instance.Tags = hit.transform.tag; // 아 모르겠고 그냥 Tag 저장함
            GameManager.instance.Tags = hit.transform.tag;

            Debug.Log(hit.transform.tag);
        }

        else
        {
            UIManager.instance.Interaction_canvas = false;
            GameManager.instance.Tags = "sena";
            UIManager.instance.Tags = "sena"; // 이건 그냥 쓰레기 값임. 
        }


    }

}

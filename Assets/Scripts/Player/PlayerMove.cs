using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private Rigidbody playerRigidbody;
    public float speed;
    public float rotateSpeed;

    float newX = 0;
    float newY = 0;

    // Start is called before the first frame update
    void Start()
    {
       playerRigidbody = GetComponent<Rigidbody>();
       MouseHold();
    }

    // Update is called once per frame
    void Update()
    {

        Move();
        Rotate();
      //  MouseHold();

    }

    void Move()
    {

        Vector3 move = transform.forward * Input.GetAxisRaw("Vertical") +transform.right * Input.GetAxisRaw("Horizontal");

        move.y = 0;

        transform.position += move * speed * Time.deltaTime;

    }


    void Rotate()
    {

        float yRotate = Input.GetAxis("Mouse X");
        newY += rotateSpeed * yRotate;

        float xRotate = Input.GetAxis("Mouse Y");
        newX += rotateSpeed * xRotate;

        newX = Mathf.Clamp(newX, -40f, 35f); //�þ߰�
        transform.eulerAngles = new Vector3(-newX, newY, 0f);

    }

    void MouseHold()
    {
        Cursor.lockState = CursorLockMode.Confined; // Ŀ�� �Ⱥ��̰� �ϱ�
        Cursor.lockState = CursorLockMode.Locked; // Ŀ�� �߾ӿ� �ھƵα�
    }

}

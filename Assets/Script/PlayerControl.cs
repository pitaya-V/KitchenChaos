using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7;
    [SerializeField] private float rotateSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = new Vector2();
        if (Input.GetKey(KeyCode.W))
            inputVector.y = +1;
        if (Input.GetKey(KeyCode.S))
            inputVector.y = -1;
        if (Input.GetKey(KeyCode.A))
            inputVector.x = -1;
        if (Input.GetKey(KeyCode.D))
            inputVector.x = +1;

        inputVector = inputVector.normalized;
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += moveDir * moveSpeed * Time.deltaTime;
        //���������ת��Ϊ��ƽ��һ�㣬ʹ��Slerp������
        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotateSpeed);
    }
}

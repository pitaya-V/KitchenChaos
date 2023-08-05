using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7;
    [SerializeField] private float rotateSpeed = 10f;
    [SerializeField] private GameInput gameInput;

    private bool isWalking;

    public bool IsWalking { get => isWalking; set => isWalking = value; }

    // Update is called once per frame
    void Update()
    {
        var inputVector = gameInput.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        isWalking = moveDir!=Vector3.zero;
        transform.position += moveDir * moveSpeed * Time.deltaTime;
        //���������ת��Ϊ��ƽ��һ�㣬ʹ��Slerp������
        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotateSpeed);
    }
}

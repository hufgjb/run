using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    Rigidbody2D rigid2D;          // �Ψө�߫}�����餽�}�ܼ�
    float jumpForce = 680.0f;     // ���D�O�w�]��

    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();  // ���o�߫}������
    }

    void Update()
    {
        // ���D
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid2D.AddForce(transform.up * jumpForce);
        }
    }
}
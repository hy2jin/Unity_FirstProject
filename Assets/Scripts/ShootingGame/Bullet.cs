using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // �̵� �ӵ�
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ������ ����
        Vector3 dir = Vector3.up;
        // �̵�
        transform.position += dir * speed * Time.deltaTime;
    }
}

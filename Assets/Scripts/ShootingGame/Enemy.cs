using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ����
        Vector3 dir = Vector3.down;
        // �̵�
        transform.position += dir * speed * Time.deltaTime;
    }

    // �浹 ����
    private void OnCollisionEnter(Collision collision)
    {
        // �� ������Ʈ ���� (�� ���� ������Ʈ)
        Destroy(gameObject);
        // �÷��̾� ������Ʈ ���� (�浹 ���)
        Destroy(collision.gameObject);
    }
}

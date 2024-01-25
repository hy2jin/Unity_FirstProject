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
        // 방향
        Vector3 dir = Vector3.down;
        // 이동
        transform.position += dir * speed * Time.deltaTime;
    }

    // 충돌 감지
    private void OnCollisionEnter(Collision collision)
    {
        // 적 오브젝트 제거 (내 게임 오브젝트)
        Destroy(gameObject);
        // 플레이어 오브젝트 제거 (충돌 대상)
        Destroy(collision.gameObject);
    }
}

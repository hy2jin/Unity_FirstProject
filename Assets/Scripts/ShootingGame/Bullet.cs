using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // 이동 속도
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 방향을 구함
        Vector3 dir = Vector3.up;
        // 이동
        transform.position += dir * speed * Time.deltaTime;
    }
}

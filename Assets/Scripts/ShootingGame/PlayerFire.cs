using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // 총알 공장
    public GameObject bulletFactory;
    // 발사 위치
    public GameObject firePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // 총알 공장에서 총알 생성
            GameObject bullet = Instantiate(bulletFactory); // Prefab만 생성 가능
            // 총알 발사
            bullet.transform.position = firePosition.transform.position;
        }
    }
}

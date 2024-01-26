using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // 배경 매터리얼
    public Material bgMaterial;
    // 스크롤 속도
    public float speed = 0.2f;

    // Update is called once per frame
    void Update()
    {
        // 매터리얼 속성 값이 Vector2이기 때문에 2로 해야함
        Vector2 dir = Vector2.up;
        bgMaterial.mainTextureOffset += dir * speed * Time.deltaTime;
    }
}

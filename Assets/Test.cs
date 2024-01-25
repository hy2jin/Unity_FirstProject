using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    // FPS (frame per seconds)
    void Start()    // 초기화
    {
        print("Hello world!");
    }

    // Update is called once per frame
    // 60 FPS => 1초에 60번 업데이트 됨
    void Update()
    {
        print("Update!");
    }
}

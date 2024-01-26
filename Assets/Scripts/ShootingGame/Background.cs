using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // ��� ���͸���
    public Material bgMaterial;
    // ��ũ�� �ӵ�
    public float speed = 0.2f;

    // Update is called once per frame
    void Update()
    {
        // ���͸��� �Ӽ� ���� Vector2�̱� ������ 2�� �ؾ���
        Vector2 dir = Vector2.up;
        bgMaterial.mainTextureOffset += dir * speed * Time.deltaTime;
    }
}

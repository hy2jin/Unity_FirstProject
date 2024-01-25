using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // �Ѿ� ����
    public GameObject bulletFactory;
    // �߻� ��ġ
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
            // �Ѿ� ���忡�� �Ѿ� ����
            GameObject bullet = Instantiate(bulletFactory); // Prefab�� ���� ����
            // �Ѿ� �߻�
            bullet.transform.position = firePosition.transform.position;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // ���� �ð�
    float currentTime;
    // ���� �ð�
    public float createTime;
    // �� ����
    public GameObject enemyFactory;

    float minTime = 1f;
    float maxTime = 5f;
    

    // Start is called before the first frame update
    void Start()
    {
        createTime = UnityEngine.Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        // ���� �ð��� ���� �ð����� Ŀ����
        if (currentTime > createTime)
        {
            // �� ���忡�� �� ����
            GameObject enemy = Instantiate(enemyFactory);
            // �� ���� ��ġ(�� ��ġ)�� ����
            enemy.transform.position = transform.position;
            // ���� �ð��� 0���� �ʱ�ȭ
            currentTime = 0;
            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }
    }
}

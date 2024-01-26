using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // 현재 시간
    float currentTime;
    // 일정 시간
    public float createTime;
    // 적 공장
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
        // 현재 시간이 일정 시간보다 커지면
        if (currentTime > createTime)
        {
            // 적 공장에서 적 생성
            GameObject enemy = Instantiate(enemyFactory);
            // 적 생성 위치(내 위치)로 변경
            enemy.transform.position = transform.position;
            // 현재 시간을 0으로 초기화
            currentTime = 0;
            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }
    }
}

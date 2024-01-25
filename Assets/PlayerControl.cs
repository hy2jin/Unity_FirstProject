using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControl : MonoBehaviour
{
    float speed = 5f;
    public float p_speed = 5f;
    int count;
    public TextMeshProUGUI countText;
    public GameObject clearText;

    void SetCount()
    {
        countText.text = "Score: " + count.ToString();
        if (count >= 100)
        {
            clearText.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCount();
        clearText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //Debug.Log("h: " + h);
        //Debug.Log("v: " + v);

        // 거리 = 속력 X 시간
        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        transform.Translate(h * Vector3.right);
        transform.Translate(v * Vector3.forward);
    }

    private void OnCollisionEnter(Collision collision)  // 충돌한 대상이 collision
    {
        Debug.Log("충돌 감지!!");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item"))
        {
            other.gameObject.SetActive(false);
            count += 10;
            Debug.Log("count: " + count);
            SetCount();
        }
        Debug.Log("트리거 감지!!");
    }
}

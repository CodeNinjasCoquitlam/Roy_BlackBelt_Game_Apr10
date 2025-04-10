using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestShake : MonoBehaviour
{

    private Vector2 OP;
    // Start is called before the first frame update
    void Start()
    {
        OP = new Vector3(415, 61, -1);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gameObject.transform.position = new Vector3(415, 120, -0.1f);
            gameObject.transform.localScale = new Vector3(2100, 2243, 1);
            StartCoroutine(Shake());
        }
    }
    IEnumerator Shake()
    {
        float ET = 0f;
        while (ET < 3f)
        {
            transform.position = OP + new Vector2(Random.Range(-10, 10), Random.Range(-10, 10));
                ET += Time.deltaTime;
            yield return null;

        }
    }
    public void StopShake()
    {
        
    }
}

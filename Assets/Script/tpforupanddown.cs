using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tpforupanddown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x >= 11)
        {
            int level = Random.Range(1, 5);
            SceneManager.LoadScene(level);
        }

        if (gameObject.transform.position.x <= -10)
        {
            int level = Random.Range(1, 5);
            SceneManager.LoadScene(level);
        }
    }
}

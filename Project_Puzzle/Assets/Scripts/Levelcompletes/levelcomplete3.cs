using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcomplete3 : MonoBehaviour
{
    public int complete3 = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "goal")
        {
            Debug.Log("Hit goal");
            complete3 = 1;
            variablepass.complete3 = complete3;
            SceneManager.LoadScene("Level Complete");
        }
    }
}

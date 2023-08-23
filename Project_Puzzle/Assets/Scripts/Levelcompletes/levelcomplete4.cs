using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcomplete4 : MonoBehaviour
{
    public int complete4 = 0;
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
            complete4 = 1;
            variablepass.complete4 = complete4;
            SceneManager.LoadScene("Level Complete");
        }
    }
}

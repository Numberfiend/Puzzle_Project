using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcomplete2 : MonoBehaviour
{
    public int complete2 = 0;
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
            complete2 = 1;
            variablepass.complete2 = complete2;
            SceneManager.LoadScene("Level Complete");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathblock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "deathb")
        {
            OpenScene();
            Debug.Log("Hit deathblock");
            Destroy(this.gameObject);
           

        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OpenScene()
    {
        SceneManager.LoadScene("LevelFail");
    }
}

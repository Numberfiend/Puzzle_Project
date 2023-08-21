using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyunlock1 : MonoBehaviour
{

    public int unlock = 0;

    public Color newcolor;
    private SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        unlock = variablepass.complete;
    }

    // Update is called once per frame
    void Update()
    {
        if(unlock == 1)
        {
            rend = GetComponent<SpriteRenderer>();
            rend.color = newcolor;
        }
    }
}

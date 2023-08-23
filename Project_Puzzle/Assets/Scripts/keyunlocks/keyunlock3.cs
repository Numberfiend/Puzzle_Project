using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyunlock3 : MonoBehaviour
{
    public int unlock3 = 0;

    public Color newcolor;
    private SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        unlock3 = variablepass.complete3;
    }

    // Update is called once per frame
    void Update()
    {
        if (unlock3 == 1)
        {
            rend = GetComponent<SpriteRenderer>();
            rend.color = newcolor;
        }
    }
}

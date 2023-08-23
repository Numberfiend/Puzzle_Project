using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyunlock4 : MonoBehaviour
{
    public int unlock4 = 0;

    public Color newcolor;
    private SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        unlock4 = variablepass.complete4;
    }

    // Update is called once per frame
    void Update()
    {
        if (unlock4 == 1)
        {
            rend = GetComponent<SpriteRenderer>();
            rend.color = newcolor;
        }
    }
}

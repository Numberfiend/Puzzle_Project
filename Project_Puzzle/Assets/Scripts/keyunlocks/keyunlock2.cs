using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyunlock2 : MonoBehaviour
{
    public int unlock2 = 0;

    public Color newcolor;
    private SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        unlock2 = variablepass.complete2;
    }

    // Update is called once per frame
    void Update()
    {
        if (unlock2 == 1)
        {
            rend = GetComponent<SpriteRenderer>();
            rend.color = newcolor;
        }
    }
}

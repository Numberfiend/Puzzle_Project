using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyunlock5 : MonoBehaviour
{
    public int unlock5 = 0;

    public Color newcolor;
    private SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        unlock5 = variablepass.complete5;
    }

    // Update is called once per frame
    void Update()
    {
        if (unlock5 == 1)
        {
            rend = GetComponent<SpriteRenderer>();
            rend.color = newcolor;
        }
    }
}

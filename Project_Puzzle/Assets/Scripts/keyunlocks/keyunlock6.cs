using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyunlock6 : MonoBehaviour
{
    public int unlock6 = 0;

    public Color newcolor;
    private SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        unlock6 = variablepass.complete6;
    }

    // Update is called once per frame
    void Update()
    {
        if (unlock6 == 1)
        {
            rend = GetComponent<SpriteRenderer>();
            rend.color = newcolor;
        }
    }
}

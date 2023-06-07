using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class transformacoes : MonoBehaviour
{

    private Rigidbody rb;

    public float deslocamento = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transformTranslate();
    }

    void transformTranslate()
    {
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.Translate(deslocamento, 0, 0);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.Translate(-deslocamento, 0, 0);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, -deslocamento);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, deslocamento);
        }
    }
}

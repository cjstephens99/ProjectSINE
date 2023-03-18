using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notePlay : MonoBehaviour
{
    private bool onTarget;
    private CircleCollider2D cc;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onTarget)
        {
            Debug.Log("Note Hit!");
            Destroy(gameObject);
        } else if (Input.GetKeyDown(KeyCode.Space) && !onTarget)
        {
            Debug.Log("Note Missed :(");
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        onTarget = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        onTarget = false;
    }

}

    

    

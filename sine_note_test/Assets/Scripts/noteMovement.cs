using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteMovement : MonoBehaviour
{
    public int speed = 5;
    private int direction;

    enum Directions
    {
        Left,
        Right
    }

    [SerializeField]
    Directions moveDirection = new Directions();

    // Start is called before the first frame update
    void Start()
    {
        
        switch (moveDirection)
        {
            case Directions.Left:
                direction = -1;
                break;
            case Directions.Right:
                direction = 1;
                break;
            default:
                direction = -1;
                Debug.LogWarning("Note Direction not set, default to left");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // move note
        transform.position += new Vector3(direction*speed*Time.deltaTime, Mathf.Sin(transform.position.x)/100, 0);

    }
}

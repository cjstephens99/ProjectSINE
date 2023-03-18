using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createNote : MonoBehaviour
{

    public GameObject notePreFab;
    private Vector3 noteSpawnPos = new Vector3(10, 0, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Spawn Note")]
    public void spawnNote()
    {
        Instantiate(notePreFab, noteSpawnPos, transform.rotation);
    }
}

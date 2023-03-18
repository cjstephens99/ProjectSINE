using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createTarget : MonoBehaviour
{
    public GameObject targetPreFab;
    public Vector3 targetSpawnPos = new Vector3(-5, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Spawn Target")]
    void spawnTarget()
    {
        Instantiate(targetPreFab, targetSpawnPos, transform.rotation);
    }
}

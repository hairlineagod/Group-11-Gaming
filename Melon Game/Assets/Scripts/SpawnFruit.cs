using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruit : MonoBehaviour
{
    public bool spawned = false;
    public GameObject Strawberry;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawned == true)
        {
            Debug.Log("spawning");
            Instantiate(Strawberry, transform.position, new Quaternion(-90, 0, 0, -90));
            spawned = false;
        }
    }
}

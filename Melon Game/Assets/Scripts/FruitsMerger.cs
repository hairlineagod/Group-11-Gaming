using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsMerger : MonoBehaviour
{
    public GameObject Strawberry;
    public GameObject player;
    public SpawnFruit spawnFruit;
    // Start is called before the first frame update
    void Awake()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cherry" && gameObject.tag == "Cherry")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            spawnFruit.spawned = true;
        }
    }
}

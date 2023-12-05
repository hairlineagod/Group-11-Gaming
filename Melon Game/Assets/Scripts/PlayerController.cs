using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public GameObject[] fruits;
    public int whichFruit;
    public bool spawned = false;
    public Vector3 spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Player");
        //If a or left arrow key is held move buckets to the left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        //If d or right arrow key is held move buckets to the right
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pressed Space");
            Instantiate(fruits[0], transform.position, new Quaternion(-90, 0, 0, -90));
        }
        if (spawned == true)
        {
            Debug.Log("spawning");
            Instantiate(fruits[whichFruit], spawnPos, new Quaternion(-90, 0, 0, -90));
            spawned = false;
        }

    }
}

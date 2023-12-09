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
    public float totalScore = 0f;
    private float cherryPointValue = 5f;
    private float strawberryPointValue = 10f;
    private float applePointValue = 15f;
    private float orangePointValue = 20f;
    private float pearPointValue = 25f;
    private float melonPointValue = 30f;
    private float watermelonPointValue = 35f;

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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cherry")
        {
            totalScore += cherryPointValue;

        }
        if (other.gameObject.tag == "Strawberry")
        {
            totalScore += strawberryPointValue;
        }
        if (other.gameObject.tag == "Apple")
        {
            totalScore += applePointValue;
        }
        if (other.gameObject.tag == "Orange")
        {
            totalScore += orangePointValue;
        }
        if (other.gameObject.tag == "Pear")
        {
            totalScore += pearPointValue;
        }
        if (other.gameObject.tag == "Melon")
        {
            totalScore += melonPointValue;
        }
        if (other.gameObject.tag == "Watermelon")
        {
            totalScore += watermelonPointValue;
        }
    }
}

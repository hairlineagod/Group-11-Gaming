using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsMerger : MonoBehaviour
{

    public GameObject player;
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
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 1;
        }
        if (other.tag == "Strawberry" && gameObject.tag == "Strawberry")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 2;
        }
        if (other.tag == "Grape" && gameObject.tag == "Grape")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 3;
        }
        if (other.tag == "Dekopon" && gameObject.tag == "Dekopon")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 4;
        }
        if (other.tag == "Orange" && gameObject.tag == "Orange")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 5;
        }
        if (other.tag == "Apple" && gameObject.tag == "Apple")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 6;
        }
        if (other.tag == "Pear" && gameObject.tag == "Pear")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 7;
        }
        if (other.tag == "Peach" && gameObject.tag == "Peach")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 8;
        }
        if (other.tag == "Pineapple" && gameObject.tag == "Pineapple")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 9;
        }
        if (other.tag == "Melon" && gameObject.tag == "Melon")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 10;
        }
        if (other.tag == "Watermelon" && gameObject.tag == "Watermelon")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}

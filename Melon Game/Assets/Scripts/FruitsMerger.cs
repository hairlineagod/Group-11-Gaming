using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FruitsMerger : MonoBehaviour
{

    public GameObject player;
    private float cherryPointValue = 1f;
    private float strawberryPointValue = 3f;
    private float grapePointValue = 6f;
    private float dekoponPointValue = 10f;
    private float orangePointValue = 28f;
    private float applePointValue = 36f;
    
    private float pearPointValue = 45f;
    private float peachPointValue = 55f;
    private float pineapplePointValue = 66f;
    private float melonPointValue = 78f;
    private float watermelonPointValue = 100f;
    public GameObject loseText;
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
        if (other.tag == "Out")
        {
            // display text or just go straight to game over
            // SceneManager.LoadScene(sceneIndex);
            loseText.SetActive(true);
            player.GetComponent<PlayerController>().lost = true;
        }
        if (other.tag == "Cherry" && gameObject.tag == "Cherry")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 1;
            player.GetComponent<PlayerController>().totalScore += cherryPointValue;
        }
        if (other.tag == "Strawberry" && gameObject.tag == "Strawberry")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 2;
            player.GetComponent<PlayerController>().totalScore += strawberryPointValue;
        }
        if (other.tag == "Grape" && gameObject.tag == "Grape")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 3;
            player.GetComponent<PlayerController>().totalScore += grapePointValue;
        }
        if (other.tag == "Dekopon" && gameObject.tag == "Dekopon")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 4;
            player.GetComponent<PlayerController>().totalScore += dekoponPointValue;
        }
        if (other.tag == "Orange" && gameObject.tag == "Orange")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 5;
            player.GetComponent<PlayerController>().totalScore += orangePointValue;
        }
        if (other.tag == "Apple" && gameObject.tag == "Apple")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 6;
            player.GetComponent<PlayerController>().totalScore += applePointValue;
        }
        if (other.tag == "Pear" && gameObject.tag == "Pear")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 7;
            player.GetComponent<PlayerController>().totalScore += pearPointValue;
        }
        if (other.tag == "Peach" && gameObject.tag == "Peach")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 8;
            player.GetComponent<PlayerController>().totalScore += peachPointValue;
        }
        if (other.tag == "Pineapple" && gameObject.tag == "Pineapple")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 9;
            player.GetComponent<PlayerController>().totalScore += pineapplePointValue;
        }
        if (other.tag == "Melon" && gameObject.tag == "Melon")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().spawned = true;
            player.GetComponent<PlayerController>().spawnPos = transform.position;
            player.GetComponent<PlayerController>().whichFruit = 10;
            player.GetComponent<PlayerController>().totalScore += melonPointValue;
        }
        if (other.tag == "Watermelon" && gameObject.tag == "Watermelon")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            player.GetComponent<PlayerController>().totalScore += watermelonPointValue;
        }
    }
}

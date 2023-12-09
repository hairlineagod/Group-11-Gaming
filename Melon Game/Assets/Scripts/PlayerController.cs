using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public GameObject[] fruits;
    private GameObject firstFruit;
    private GameObject nextFruit;
    public GameObject nextSpawn;
    public GameObject loseBlock;
    public GameObject winText;
    public int whichFruit;
    public bool spawned = false;
    public bool dropped = false;
    public bool lost = false;
    public Vector3 spawnPos;
    public bool maxLeft = false;
    public bool maxRight = false;
    private int spawnTimer = 2;
    private GameObject tempFruit;
    public float totalScore = 0f;
    private bool won = false;
 

    // Start is called before the first frame update
    void Start()
    {
        firstFruit = fruits[Random.Range(0, 5)];
        firstFruit = Instantiate(firstFruit, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), new Quaternion(-90, 0, 0, -90));
        firstFruit.GetComponent<Rigidbody>().useGravity = false;
        firstFruit.GetComponent<FruitsMerger>().enabled = false;
        firstFruit.GetComponent<MeshCollider>().enabled = false;
        firstFruit.transform.parent = transform;

        nextFruit = fruits[Random.Range(0, 5)];
        tempFruit = nextFruit;
        tempFruit.GetComponent<Rigidbody>().useGravity = false;
        tempFruit = Instantiate(tempFruit, nextSpawn.transform.position, new Quaternion(-90, 0, 0, -90));
        nextFruit.GetComponent<Rigidbody>().useGravity = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (totalScore >= 1000 && SceneManager.GetActiveScene().buildIndex == 2)
        {
            winText.SetActive(true);
            won = true;
        }
        if (totalScore >= 1500 && SceneManager.GetActiveScene().buildIndex == 3)
        {
            winText.SetActive(true);
            won = true;
        }
        if (!won)
        {
            if (!lost)
            {
                //If a or left arrow key is held move buckets to the left
                if (Input.GetKey(KeyCode.A) && maxLeft == false || Input.GetKey(KeyCode.LeftArrow) && maxLeft == false)
                {
                    transform.position += Vector3.left * speed * Time.deltaTime;
                }
                //If d or right arrow key is held move buckets to the right
                if (Input.GetKey("d") && maxRight == false || Input.GetKey(KeyCode.RightArrow) && maxRight == false)
                {
                    transform.position += Vector3.right * speed * Time.deltaTime;
                }
                if (Input.GetKeyDown(KeyCode.Space) && dropped == false)
                {
                    Debug.Log("Pressed Space");

                    StartCoroutine(SpawnFruit());

                }
                if (spawned == true)
                {
                    Debug.Log("spawning");
                    Instantiate(fruits[whichFruit], spawnPos, new Quaternion(-90, 0, 0, -90));
                    spawned = false;

                }
            }
        }
        
        
        


}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MaxLeft")
        {
            maxLeft = true;
        }
        if (other.tag == "MaxRight")
        {
            maxRight = true;
        }
        if (other.tag == "ResetLeft")
        {
            maxLeft = false;
        }
        if (other.tag == "ResetRight")
        {
            maxRight = false;
        }
    }

    IEnumerator SpawnFruit()
    {
        dropped = true;
        loseBlock.SetActive(false);
        firstFruit.transform.parent = null;
        firstFruit.GetComponent<Rigidbody>().useGravity = true;
        firstFruit.GetComponent<FruitsMerger>().enabled = true;
        yield return new WaitForSeconds(spawnTimer);
        loseBlock.SetActive(true);
        firstFruit = nextFruit;
        firstFruit = Instantiate(firstFruit, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), new Quaternion(-90, 0, 0, -90));
        firstFruit.GetComponent<Rigidbody>().useGravity = false;
        firstFruit.GetComponent<FruitsMerger>().enabled = false;
        firstFruit.transform.parent = transform;

        tempFruit.SetActive(false);
        nextFruit.SetActive(true);
        nextFruit = fruits[Random.Range(0, 5)];

        tempFruit = nextFruit;
        Debug.Log("Temp Fruit gone");

        tempFruit.SetActive(true);
        nextFruit.GetComponent<Rigidbody>().useGravity = true;
        tempFruit = Instantiate(tempFruit, nextSpawn.transform.position, new Quaternion(-90, 0, 0, -90));
        tempFruit.GetComponent<Rigidbody>().useGravity = false;
        Debug.Log("Temp Fruit back");
        dropped = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_Spawner : MonoBehaviour
{
    #region Variables
    public int openingDir;
    /* 1 = bottom
     * 2 = top
     * 3 = left
     * 4 = right
     */
    private Room_Templates templates;
    private int rand;
    private bool spawned = false;
    private float waitTime = 4f;
    #endregion

    #region Main Functions
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, waitTime);
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<Room_Templates>();
        Invoke("Spawn", 0.1f);
    }

    // Update is called once per frame
    void Spawn()
    {
        if(spawned == false)
        {
            if (openingDir == 1)
            {
                //needs to spawn room if bottom door
                rand = Random.Range(0, templates.topRooms.Length);
                Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
            }
            else if (openingDir == 2)
            {
                //needs to spawn room with top door
                rand = Random.Range(0, templates.bottomRooms.Length);
                Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
            }
            else if (openingDir == 3)
            {
                //needs to spawn room with left door
                rand = Random.Range(0, templates.righRooms.Length);
                Instantiate(templates.righRooms[rand], transform.position, templates.righRooms[rand].transform.rotation);
            }
            else if (openingDir == 4)
            {
                //needs to spawn room with right door
                rand = Random.Range(0, templates.leftRooms.Length);
                Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
            }
            spawned = true;
        }
    }
    #endregion

    #region Custom Functions
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("SpawnPoint")) //&& hit.GetComponent<Room_Spawner>().spawned == true)
        {
            if (hit.GetComponent<Room_Spawner>().spawned == false && spawned == false)
            {
                Instantiate(templates.closedRooms, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
        spawned = true;
    }
    #endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_Templates : MonoBehaviour
{
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] righRooms;

    public GameObject closedRooms;

    public List<GameObject> rooms;

    [SerializeField] private float waitTime;
    private bool spawnedBoss;
    [SerializeField] private GameObject boss = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(waitTime <= 0 && spawnedBoss == false)
        {
            for(int c = 0; c < rooms.Count; c++)
            {
                if(c == rooms.Count - 1)
                {
                    Instantiate(boss, rooms[c].transform.position, Quaternion.identity);
                    spawnedBoss = true;
                }
            }
        }
        else
        {
            waitTime -= Time.deltaTime;
        }
    }
}

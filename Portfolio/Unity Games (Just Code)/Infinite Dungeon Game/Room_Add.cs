using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_Add : MonoBehaviour
{
    private Room_Templates templates;
    // Start is called before the first frame update
    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<Room_Templates>();
        templates.rooms.Add(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int level = 1;
    public float speed = 1.5f;
    public int health = 1;
    private Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        
        health += level;
        //вывод health на консоль
        print("health");
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}

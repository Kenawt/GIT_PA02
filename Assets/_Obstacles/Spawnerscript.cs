using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject[] SpawnObject;
    float PositionX;
    private int Spawned;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnObjects()
    {
        Spawned = Random.Range(0, 3);
        PositionX = Random.Range(3, -3f);
        this.transform.position = new Vector3(PositionX, transform.position.y, transform.position.z);
        Instantiate(SpawnObject[Spawned], transform.position, transform.rotation);
    }
}

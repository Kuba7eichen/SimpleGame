using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnBullet(Vector3 pos, Vector3 dir)
    {
        print("SpawningBullet from " + pos + " to " + dir);
    }
}

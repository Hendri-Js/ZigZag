using Unity.Mathematics;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] private GameObject platform;
    private Vector3 pos;
    private Vector3 lastPos;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lastPos = platform.transform.position;
        for (int i = 0; i < 5; i++)
        {
            SpawnX();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnX()
    {
        pos = lastPos;
        pos.x += platform.transform.localScale.x * 10;
        lastPos = pos;
        Instantiate(platform, pos, quaternion.identity);
    }

    void SpawnZ()
    {
        pos = lastPos;
        pos.z += platform.transform.localScale.z * 10;
        lastPos = pos;
        Instantiate(platform, pos, quaternion.identity);
    }
}

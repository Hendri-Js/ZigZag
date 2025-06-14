using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    [SerializeField] private GameObject cube;
    [SerializeField] private float lerpSpeed;
    private Vector3 offset;
    
    public bool gameOver;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = cube.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            Follow();
        }
    }

    void Follow()
    {
        Vector3 pos = transform.position;
        Vector3 posTarget = cube.transform.position - offset;
        pos = Vector3.Lerp(pos, posTarget, lerpSpeed * Time.deltaTime);
        transform.position = pos;
    }
}

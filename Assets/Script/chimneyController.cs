using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chimneyController : MonoBehaviour
{
    private float timer = 1.2f;
    private float height = 0.5f;
    public GameObject chimney;
    public GameObject chimneyClone;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            Pipe();
    }

    void Pipe()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            chimneyClone = Instantiate(chimney, transform.position + new Vector3(0, Random.Range(-height, height), 0), chimney.transform.rotation) as GameObject;
            Destroy(chimneyClone, 5);
            timer = 1.25f;
        }
    }
}

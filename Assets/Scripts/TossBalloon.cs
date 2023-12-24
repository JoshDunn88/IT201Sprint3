using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TossBalloon : MonoBehaviour
{

    public GameObject balloonFab;
    public GameObject cam;
    private Rigidbody ballRB;
    // Start is called before the first frame update
    void Start()
    {
        ballRB = balloonFab.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Toss()
    {
        balloonFab.transform.position = cam.transform.position + new Vector3(0,1,0);
        balloonFab.transform.rotation = cam.transform.rotation;
        //ballRB.AddRelativeForce(new Vector3(0, 0, 10f));
        Instantiate(ballRB);
        ballRB.AddRelativeForce(new Vector3(0, 0, 10f));
    }
}

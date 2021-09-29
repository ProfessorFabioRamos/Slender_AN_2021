using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public int points = 0;
    public Text pointText;
    public Camera fpsCamera;
    public float getItemDist = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = points + "/8";

        RaycastHit hit;

        Vector3 rayOrigin = fpsCamera.ViewportToWorldPoint
            (new Vector3(0.5f, 0.5f,0));

        if (Physics.Raycast(rayOrigin, fpsCamera.transform.forward, out hit, getItemDist))
        {
            //Debug.Log(hit.transform.name);
            if(hit.transform.tag == "Gun")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Collect")
        {
            points++;
            Destroy(other.gameObject);
        }
    }
}

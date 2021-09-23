using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public int points = 0;
    public Text pointText;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = points + "/8";
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

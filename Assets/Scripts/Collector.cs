using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    GameObject mainWood;
    private int length;

    void Start()
    {
        mainWood = GameObject.Find("Wood");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void lengthDecrease()
    {
        length--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collect" && other.gameObject.GetComponent<CollectControl>().GetIsCollected() == false)
        {
            length++;
            other.gameObject.GetComponent<CollectControl>().MakeCollected();
            other.gameObject.GetComponent<CollectControl>().IndexCollector(length);
            other.gameObject.transform.parent = mainWood.transform;
            other.gameObject.GetComponent<RotationControl>().enabled = true;
            //mainWood.transform.position += new Vector3(0,0,-1);
            this.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + 1);
        }
    }
}

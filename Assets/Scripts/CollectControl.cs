using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectControl : MonoBehaviour
{
    private bool isCollected;
    private int index;
    public Collector collector;

    // Update is called once per frame
    void Update()
    {
        if (isCollected)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, 0, +index);
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Saw")
        {
            collector.lengthDecrease();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            Destroy(other.gameObject);
        }
    }

    public bool GetIsCollected()
    {
        return isCollected;
    }

    public void MakeCollected()
    {
        isCollected = true;
    }

    public void IndexCollector(int index)
    {
        this.index = index;
    }

}

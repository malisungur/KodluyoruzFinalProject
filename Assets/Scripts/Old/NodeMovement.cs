using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public Transform connectedNode;
    bool isMove = true;


    // Update is called once per frame
    void Update()
    {
        if (isMove)
        {
            transform.position = new Vector3(
           Mathf.Lerp(transform.position.x, connectedNode.position.x, Time.deltaTime * 20),
           connectedNode.position.y,
           connectedNode.position.z + 1
           );
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (transform.CompareTag("Collected") && other.CompareTag("Saw"))
        {
            Destroy(other.gameObject);
            GetComponent<BoxCollider>().isTrigger = true;
            isMove = false;
        }
    }


}

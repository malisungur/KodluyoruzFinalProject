using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float forwardSpeed;
    [SerializeField] float horizontalSpeed;
    private float horizontalMove;
    private float maxSide = 7.5f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;
        this.transform.Translate(horizontalMove, 0, forwardSpeed * Time.deltaTime);

        if (this.transform.position.x < -maxSide)
        {
            this.transform.position = new Vector3(-maxSide, this.transform.position.y, this.transform.position.z);
        }

        if (this.transform.position.x > maxSide)
        {
            this.transform.position = new Vector3(maxSide, this.transform.position.y, this.transform.position.z);
        }

    }
}

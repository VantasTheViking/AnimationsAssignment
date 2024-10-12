using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] Animator animator;
    bool running;
    float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
            running = true;
        } else
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
            running = true;

        } else
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            running = true;

        } else
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            running = true;

        } else
        {
            running = false;
        }
        animator.SetBool("isRunning", running);

        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("BSwing");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {

            animator.SetTrigger("CSwing");
        }

    }
}

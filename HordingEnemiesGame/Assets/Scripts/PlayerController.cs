using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector3 pos = new Vector3(0f, 0f, 0f);
        pos.x = Input.GetAxisRaw("Horizontal");
        pos.y = Input.GetAxisRaw("Vertical");
        if (pos.x < 0f)
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        else
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);

        pos.Normalize();

        transform.position += pos * moveSpeed * Time.deltaTime;
        if (pos != Vector3.zero)
        {
            anim.SetBool("isMoving", true);
        }
        else
        {
            anim.SetBool("isMoving", false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBullet : MonoBehaviour
{
    float timer = 0;
    Rigidbody rb;
    int hasDamaged = 0; //flag to avoid having the projectile hit the player more than once.
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        rb.AddForce(transform.forward * 20);
        if (timer >= 1)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && hasDamaged == 0)
        {
            hasDamaged = 1;
            //print("DAMAGE!");
            other.gameObject.GetComponent<PlayerControllerAnimation>().playerCurrentHealth -= 10;
        }
    }
}

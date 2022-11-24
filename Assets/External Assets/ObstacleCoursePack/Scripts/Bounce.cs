using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float force = 10f; //Force 10000f
    public float stunTime = 0.5f;
    public Rigidbody m_Rigidbody;
    private Vector3 hitDir;

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
            if (collision.gameObject.tag == "PlayerTabrak")
            {
                Debug.Log("Hit");
                m_Rigidbody.AddForce(transform.up * 20f);

                // hitDir = contact.normal;
                // collision.gameObject.GetComponent<CharacterControls>().HitPlayer(-hitDir * force, stunTime);
                return;
            }
        }
        if (collision.relativeVelocity.magnitude > 2)
        {
            if (collision.gameObject.tag == "PlayerTabrak")
            {
                Debug.Log("Hit");
                // collision.gameObject.GetComponent<CharacterControls>().HitPlayer(-hitDir * force, stunTime);
            }
            //audioSource.Play();
        }
    }
}

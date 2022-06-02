using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rigidBody;

    public float force;

    public bool brushmoving;

    public Vector3 brushTransform;

    Vector3 originalPosition;
    Quaternion originalRotation;

    private void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
    }
    private void Update()
    {
        if(brushmoving)
        {
            if (transform.localPosition.x > 0.5f)
            {
                transform.localPosition = new Vector3(0.5f, transform.localPosition.y, transform.localPosition.z);
                StopMotion();
            }

            if (transform.localPosition.x < -0.6f)
            {
                transform.localPosition = new Vector3(-0.6f, transform.localPosition.y, transform.localPosition.z);
                StopMotion();
            }
        }
    }

    public void TransformNew()
    {
        transform.rotation = Quaternion.Euler(0, 0, -90);
        transform.localPosition = brushTransform;
    }
    public void TransformReset()
    {
        transform.position = originalPosition;
        transform.rotation = originalRotation;
    }
    public void SetChild()
    {
        transform.SetParent(player.transform.parent);
    }
    public void RemoveChild()
    {
        transform.SetParent(null);
    }
    public void MoveLeft()
    {
        rigidBody.velocity = new Vector3(-force, 0, 0);
    }
    public void MoveRight()
    {
        rigidBody.velocity = new Vector3(force, 0, 0);
    }
    public void StopMotion()
    {
        rigidBody.velocity = Vector3.zero;
    }

}

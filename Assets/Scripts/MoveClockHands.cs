using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveClockHands : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public float speed = 150.0f;
    private float minuteRotation;
    public Vector3 currentSize;
    public bool anHour = false;

    void Start()
    {
        currentSize = transform.localScale;
    }

    void Update()
    {
        minuteRotation -= Time.deltaTime * speed;

        minuteHand.localRotation = Quaternion.Euler(0, 0, minuteRotation);
        hourHand.localRotation = Quaternion.Euler(0, 0, minuteRotation / 12);

        if (minuteHand.localEulerAngles.z < 3)
        {
            if (!anHour)
            {
                anHour = true;
                transform.localScale *= 1.5f;
            }
        }
        else
        {
            anHour = false;
        }

        if(minuteHand.localEulerAngles.z > 50)
            transform.localScale = currentSize;
    }
}

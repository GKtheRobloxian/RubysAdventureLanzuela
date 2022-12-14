using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LethalDamageZone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        if (controller != null)
        {
            controller.ChangeHealth(-5);
        }
    }
}

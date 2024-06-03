using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
  public int DMG;
  float cooldown = 0f;

  private void OnCollisionEnter(Collision collision)
  {
    AttributesManager health = collision.gameObject.GetComponent<AttributesManager>();
    if (health != null)
    {
        health.TakeDamage(DMG);
    }
  }
}

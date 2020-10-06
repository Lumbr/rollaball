using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public ParticleSystem hi;
    public GameObject parent;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(OnCollisionWithObstacle());
        }
    }
    public IEnumerator OnCollisionWithObstacle()
    {
        hi.Clear();
        hi.Play();
        yield return new WaitForSeconds(2);

        parent.SetActive(false);
    }


}

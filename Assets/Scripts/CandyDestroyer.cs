using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDestroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
            Destroy(other.gameObject);
    }
}

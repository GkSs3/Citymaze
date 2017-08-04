using UnityEngine;
using System.Collections;

public class points : MonoBehaviour {
    public GameObject pointsound1;
    public GameObject pointsound2;
    void OnTriggerEnter(Collider other)
    {
        scoremanager.score += 5;
        pointsound1.SetActive(true);
        Destroy(gameObject);
        pointsound2.SetActive(false);
    }
}

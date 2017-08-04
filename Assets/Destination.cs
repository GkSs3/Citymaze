using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;

public class Destination : MonoBehaviour {

    public GameObject txt;
    public GameObject playerc;

    void OnTriggerEnter(Collider other)
    {
        txt.SetActive(true);
        playerc.GetComponent<CarUserControl>().enabled = false;
        playerc.GetComponent<CarController>().enabled = false;
        playerc.GetComponent<CarAudio>().enabled = false;
        playerc.GetComponent<CarAudio>().StopSound();

        Destroy(gameObject);

    }
}

using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    public GameObject flame;
    public GameObject texto;
    // class UnityStandardAssets.Vehicles.Car.CarUserControl;

    void OnTriggerEnter(Collider other)
    {
        Instantiate(explosion, transform.position, transform.rotation);
        playerExplosion.GetComponent<CarUserControl>().enabled = false;
        playerExplosion.GetComponent<CarController>().enabled = false;
        playerExplosion.GetComponent<CarAudio>().enabled = false;
        
        flame.SetActive(true);
    
        // Destroy(playerExplosion.GetComponent<AudioSource>());
        // foreach (var source in GetComponents<AudioSource>())
        //   {
        //      Destroy(source);
        //   }
        playerExplosion.GetComponent<CarAudio>().StopSound();
        texto.SetActive(true);
    
        Destroy(gameObject);

    }
}
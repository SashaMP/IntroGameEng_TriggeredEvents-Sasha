using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Trigger : MonoBehaviour
{
    public PlayableDirector timeline;
    public GameObject trigger; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timeline.Play();
            trigger.SetActive(false);
        }

        Debug.Log("help");
    }
}

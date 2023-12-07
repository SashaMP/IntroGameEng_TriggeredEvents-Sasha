using UnityEngine;

public class WinScreen : MonoBehaviour
{
    public GameObject GameOver;
    public string targetTag = "Player";

    void Start() {
        GameOver.SetActive(false);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag(targetTag)) {
            GameOver.SetActive(true);
            Debug.Log("collided");
        }

        
    }   
}

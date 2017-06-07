using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject Restart;

    public static bool lose = false;

    void Awake()
    {
        lose = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bomb")
        { 
            lose = true;
            Restart.SetActive(true);
    }   }
}

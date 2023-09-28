using UnityEngine;

public class CatBehaviour : MonoBehaviour
{
    private AudioSource collisionSound;

    public GameObject fx;
    
    public GameObject worldObject;
    
    void Start()
    {
        worldObject = GameObject.Find("World");
        collisionSound = worldObject.GetComponent<AudioSource>();
    }

    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            worldObject.SendMessage("AddHit");
            Destroy(gameObject);
            if (collisionSound)
            {
                collisionSound.Play();
            }
            Instantiate(fx, transform.position, Quaternion.identity);
        }
    }
}
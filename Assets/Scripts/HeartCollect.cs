using UnityEngine;

public class HeartCollect : MonoBehaviour
{
    public int RotateSpeed;
    public AudioSource CollectSound;
    public GameObject HeartGameObject;

    void Update()
    {
        RotateSpeed = 2;
        transform.Rotate(0, RotateSpeed, 0, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        CollectSound.Play();
        HealthMoniter.HealthValue += 1;
        HeartGameObject.SetActive(false);
    }
}
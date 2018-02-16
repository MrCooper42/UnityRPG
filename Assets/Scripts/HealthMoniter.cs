using JetBrains.Annotations;
using UnityEngine;

public class HealthMoniter : MonoBehaviour
{
    [UsedImplicitly]
    public static int HealthValue;

    public int InternalHealth;
    public GameObject Heart01;
    public GameObject Heart02;
    public GameObject Heart03;

    private void Start()
    {
        HealthValue = 1;
    }

    private void Update()
    {
        InternalHealth = HealthValue;
        switch (HealthValue)
        {
            case 1:
                Heart01.SetActive(true);
                break;
            case 2:
                Heart02.SetActive(true);
                break;
            case 3:
                Heart03.SetActive(true);
                break;
            default: break;
        }
    }
}
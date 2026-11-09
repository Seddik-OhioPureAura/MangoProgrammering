using UnityEngine;

public class MOVEEEEE : MonoBehaviour
{
    [SerializeField] private float xSpeed = 1;
    void Start()
    {
        Debug.Log("Game Started");
    }

    void Update()
    {
        transform.Translate(xSpeed * Time.deltaTime, 0, 0);
    }
}

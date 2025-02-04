using UnityEngine;

public class CubeMover : MonoBehaviour
{
    public Vector3 targetPosition = new Vector3(0, 0, 5);
    public float moveDuration = 2f;
    private float elapsedTime = 0f;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (elapsedTime < moveDuration)
        {
            elapsedTime += Time.deltaTime;
            float progress = elapsedTime / moveDuration;
            transform.position = Vector3.Lerp(startPosition, targetPosition, progress);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

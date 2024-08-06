using UnityEngine;

public class MovingCube : MonoBehaviour
{
    public static MovingCube CurrentCube {  get; private set; }

    [SerializeField]
    private float moveSpeed = 1f;

    private void OnEnable()
    {
        CurrentCube = this;
    }
    internal void Stop()
    {
        moveSpeed = 0f;
    }
    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime * moveSpeed;
    }
}

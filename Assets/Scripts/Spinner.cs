using UnityEngine;

public class Spinner : MonoBehaviour
{
    
    [SerializeField] float xRotateSpeed = 0f;
    [SerializeField] float yRotateSpeed = 1f;
    
    [SerializeField] float zRotateSpeed = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotateSpeed, yRotateSpeed, zRotateSpeed);
    }
}

using UnityEngine;

public class Driverr : MonoBehaviour
{
    public float speed = 3.5F;

    void Start()
    {
        
    }

    void Update()
    {
       transform.Translate ( new Vector3(0,0, 1)*Time.deltaTime*speed); 
       //transform.position = transform.position + new Vector3(0,0, 1)*Time.deltaTime*speed; 
    }
}

using UnityEngine;

public class PlayerPaddleControler : MonoBehaviour
{
    public float speed = 5.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveinput = Input.GetAxis("Vertical");
        Vector3 newPosition = transform.position + Vector3.up * moveinput * speed * Time.deltaTime;
        newPosition.y = Mathf.Clamp(newPosition.y, -4.5f, 4.5f);
        transform.position = newPosition;

    }        


}

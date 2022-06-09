using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed;
    void Start()
    {
        transform.position = new Vector3(0, -4, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        float amtToMoveH = Input.GetAxisRaw("Horizontal") * playerSpeed * Time.deltaTime;
        float amtToMoveV = Input.GetAxisRaw("Vertical") * playerSpeed * Time.deltaTime;
        
        transform.Translate(Vector3.right * amtToMoveH);
        transform.Translate(Vector3.up * amtToMoveV);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 0.12f;
    [SerializeField] float xClamp;

    bool isActive = true;

    public TouchPad touchPad;

    void Update()
    {
        MovePlayerTower(isActive);

    }

    void MovePlayerTower(bool isActive)
    {
        
        
            Vector2 direction = touchPad.GetDirection();
            float xOffset = direction.x * Time.deltaTime * speed;
            float newXpos = transform.localPosition.x + xOffset;
            float xMove = Mathf.Clamp(newXpos, -xClamp, xClamp);


            transform.localPosition = new Vector3(xMove, transform.localPosition.y, transform.localPosition.z);
        
    }


}

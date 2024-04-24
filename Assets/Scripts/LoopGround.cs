using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] float _speed = 1f;
    [SerializeField] float _width = 6f;

    SpriteRenderer spriteRenderer;
    Vector2 startSize;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        startSize = new Vector2(spriteRenderer.size.x, spriteRenderer.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.size = new Vector2(spriteRenderer.size.x + _speed * Time.deltaTime, spriteRenderer.size.y);

        if (spriteRenderer.size.x > _width)
        {
            spriteRenderer.size = startSize;
        }
    }
}

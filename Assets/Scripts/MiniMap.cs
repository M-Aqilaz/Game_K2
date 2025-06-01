using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    public RectTransform minimapIcon;   // Your red dot
    public RectTransform minimapArea;   // Minimap image
    public Transform worldOrigin;       // (0,0) of your world
    public Vector2 worldSize = new Vector2(100f, 100f); // Size of your 2D world
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            Vector2 offset = new Vector2(
            transform.position.x - worldOrigin.position.x,
            transform.position.y - worldOrigin.position.y
        );

        // Normalize world position to 0–1 range
        float normalizedX = offset.x / worldSize.x;
        float normalizedY = offset.y / worldSize.y;

        // Clamp to keep inside minimap
        normalizedX = Mathf.Clamp01(normalizedX);
        normalizedY = Mathf.Clamp01(normalizedY);

        // Convert to minimap local position
        float mapWidth = minimapArea.rect.width;
        float mapHeight = minimapArea.rect.height;

        float iconX = (normalizedX * mapWidth) - (mapWidth / 2f);
        float iconY = (normalizedY * mapHeight) - (mapHeight / 2f);

        minimapIcon.anchoredPosition = new Vector2(iconX, iconY);
    }
}

using UnityEngine;
using UnityEngine.UI;

public class SpriteManager : MonoBehaviour
{
    public Button[] buttons;
    public SpriteRenderer[] sprites;
    public Vector3[] positions;

    private int nextSpriteIndex = 0;

    void Start()
    {
        // Add listeners to the buttons that call the SpawnNewSprite function
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // Need to store the index in a variable for the lambda expression to capture correctly
            buttons[i].onClick.AddListener(() => SpawnNewSprite(index));
        }
    }

    public void SpawnNewSprite(int buttonIndex)
    {
        // Get the sprite and position to use for this button
        SpriteRenderer spriteToSpawn = sprites[nextSpriteIndex];
        Vector3 positionToSpawn = positions[nextSpriteIndex];

        // Instantiate a new sprite object at the specified spawn position
        SpriteRenderer newSprite = Instantiate(spriteToSpawn, positionToSpawn, Quaternion.identity);

        // Set the parent of the new sprite object to the current transform (so it will move with this object)
        newSprite.transform.SetParent(transform);

        // Increment the index for the next sprite to spawn, wrapping around to the beginning if necessary
        nextSpriteIndex = (nextSpriteIndex + 1) % sprites.Length;
    }
}
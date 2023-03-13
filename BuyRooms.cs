using UnityEngine;
using UnityEngine.UI;

public class BuyRooms : MonoBehaviour
{
    public Button thirdButton;
    public Button fourthButton;
    public Button fifthButton;

    public SpriteRenderer spriteToSpawn1;
    public SpriteRenderer spriteToSpawn2;
    public SpriteRenderer spriteToSpawn3;
    public SpriteRenderer spriteToSpawn4;
    public SpriteRenderer spriteToSpawn5;
    public SpriteRenderer spriteToSpawn6;

    public Vector3 spriteSpawnPosition1;
    public Vector3 spriteSpawnPosition2;
    public Vector3 spriteSpawnPosition3;
    public Vector3 spriteSpawnPosition4;
    public Vector3 spriteSpawnPosition5;
    public Vector3 spriteSpawnPosition6;

    void Start()
    {
        // Add listeners to the buttons that call the functions to spawn new sprites
        thirdButton.onClick.AddListener(SpawnNewSprite1);
        fourthButton.onClick.AddListener(SpawnNewSprite2);
        fifthButton.onClick.AddListener(SpawnNewSprite3);
    }

    public void SpawnNewSprite1()
    {
        Debug.Log("Spawning new sprite 1");

        // Instantiate a new sprite object at the specified spawn position
        SpriteRenderer newSprite = Instantiate(spriteToSpawn1, spriteSpawnPosition1, Quaternion.identity);

        // Set the parent of the new sprite object to the current transform (so it will move with this object)
        newSprite.transform.SetParent(transform);
    }

    public void SpawnNewSprite2()
    {
        Debug.Log("Spawning new sprite 2");

        // Instantiate a new sprite object at the specified spawn position
        SpriteRenderer newSprite = Instantiate(spriteToSpawn2, spriteSpawnPosition2, Quaternion.identity);

        // Set the parent of the new sprite object to the current transform (so it will move with this object)
        newSprite.transform.SetParent(transform);
    }

    public void SpawnNewSprite3()
    {
        Debug.Log("Spawning new sprite 3");

        // Instantiate a new sprite object at the specified spawn position
        SpriteRenderer newSprite = Instantiate(spriteToSpawn3, spriteSpawnPosition3, Quaternion.identity);

        // Set the parent of the new sprite object to the current transform (so it will move with this object)
        newSprite.transform.SetParent(transform);

        // Call the function to spawn a second sprite after a delay
        Invoke("SpawnNewSprite4", 1.0f);
    }

    public void SpawnNewSprite4()
    {
        Debug.Log("Spawning new sprite 4");

        // Instantiate a new sprite object at the specified spawn position
        SpriteRenderer newSprite = Instantiate(spriteToSpawn4, spriteSpawnPosition4, Quaternion.identity);

        // Set the parent of the new sprite object to the current transform (so it will move with this object)
        newSprite.transform.SetParent(transform);
    }

    public void SpawnNewSprite5()
    {
        Debug.Log("Spawning new sprite 5");

        // Instantiate a new sprite object at the specified spawn position
        SpriteRenderer newSprite = Instantiate(spriteToSpawn5, spriteSpawnPosition5, Quaternion.identity);

        // Set the parent of the new sprite object to the current transform (so it will move with this object)
        newSprite.transform.SetParent(transform);
    }

    public void SpawnNewSprite6()
    {
        Debug.Log("Spawning new sprite 6");

        // Instantiate a new sprite object at the specified spawn position
        SpriteRenderer newSprite = Instantiate(spriteToSpawn6, spriteSpawnPosition6, Quaternion.identity);
        newSprite.transform.SetParent(transform);
    }
}


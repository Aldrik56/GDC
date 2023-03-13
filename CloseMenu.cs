using UnityEngine;
using UnityEngine.UI;

public class SecondButton : MonoBehaviour
{
    public Button secondButton;
    public Button thirdButton;
    public Button fourthButton;
    public Button fifthButton;
    public SpriteRenderer spriteToDisplay;
    public Vector3 secondButtonInactivePosition;
    public Vector3 spriteInitialPosition;

    void Start()
    {
        // Add a listener to the second button that calls the function to deactivate other objects
        secondButton.onClick.AddListener(DeactivateOtherObjects);

        // Add a listener to the second button itself that calls the function to deactivate other objects
        secondButton.onClick.AddListener(DeactivateSecondButtonAndSprite);
    }

    public void DeactivateOtherObjects()
    {
        Debug.Log("Deactivating other objects");

        secondButton.gameObject.SetActive(false);
        thirdButton.gameObject.SetActive(false);
        fourthButton.gameObject.SetActive(false);
        fifthButton.gameObject.SetActive(false);
        spriteToDisplay.gameObject.SetActive(false);

        secondButton.transform.position = secondButtonInactivePosition;

        spriteToDisplay.transform.position = spriteInitialPosition;
    }

    public void DeactivateSecondButtonAndSprite()
    {
        Debug.Log("Deactivating second button and sprite");
        secondButton.gameObject.SetActive(false);
        spriteToDisplay.gameObject.SetActive(false);
    }
}
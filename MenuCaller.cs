using UnityEngine;
using UnityEngine.UI;

public class MenuCaller : MonoBehaviour
{
    public Button firstButton;
    public Button secondButton;
    public Button thirdButton;
    public Button fourthButton;
    public Button fifthButton;
    public SpriteRenderer spriteToDisplay;
    public Vector3 firstButtonPosition;
    public Vector3 secondButtonInactivePosition;
    public Vector3 secondButtonActivePosition;
    public Vector3 spriteInitialPosition;
    public Vector3 spriteActivePosition;
    private bool secondButtonActive = false;

    void Start()
    { 
         SetupButtonsAndSprite();

         firstButton.onClick.AddListener(ToggleSecondButtonAndSpriteAndOtherButtons);
    }
    void SetupButtonsAndSprite()
    {
         firstButton.transform.position = firstButtonPosition;
         secondButton.transform.position = secondButtonInactivePosition;
         secondButton.gameObject.SetActive(false);
         spriteToDisplay.transform.position = spriteInitialPosition;
         spriteToDisplay.gameObject.SetActive(false);
         thirdButton.gameObject.SetActive(false);
         fourthButton.gameObject.SetActive(false);
         fifthButton.gameObject.SetActive(false);
    }

    public void ToggleSecondButtonAndSpriteAndOtherButtons()
    {
         secondButtonActive = !secondButtonActive;
         secondButton.gameObject.SetActive(secondButtonActive);
         spriteToDisplay.gameObject.SetActive(secondButtonActive);
         thirdButton.gameObject.SetActive(secondButtonActive);
         fourthButton.gameObject.SetActive(secondButtonActive);
         fifthButton.gameObject.SetActive(secondButtonActive);

         firstButton.transform.position = firstButtonPosition;

         if (secondButtonActive)
         {
              secondButton.transform.position = secondButtonActivePosition;
         }
    else
    {
        secondButton.transform.position = secondButtonInactivePosition;
    }

    if (secondButtonActive)
    {
        spriteToDisplay.transform.position = spriteActivePosition;
    }
    else
    {
        spriteToDisplay.transform.position = spriteInitialPosition;
    }
}
}

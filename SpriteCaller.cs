using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpriteCaller : MonoBehaviour
{
    public Sprite spriteToDisplay;
    public Vector3 spritePosition;
    public double cashPerSecondIncrease;
    public double fixedCashAmount = 50;
    public MainParamater mainParameter;

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(Click);
        mainParameter = FindObjectOfType<MainParamater>();
    }

    private void Click()
    {
        GameObject newSpriteObj = new GameObject("Sprite");
        newSpriteObj.transform.position = spritePosition;
        SpriteRenderer newSpriteRenderer = newSpriteObj.AddComponent<SpriteRenderer>();
        newSpriteRenderer.sprite = spriteToDisplay;
        spritePosition = new Vector3(spritePosition.x, spritePosition.y + 200f, spritePosition.z);
        mainParameter.UpgradeCashPerSecond(cashPerSecondIncrease);
        mainParameter.SetSpriteAdded(fixedCashAmount, cashPerSecondIncrease);
        mainParameter.reduceMoney(1);
    }
}

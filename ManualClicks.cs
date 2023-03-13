using UnityEngine;

public class ManualClicks : MonoBehaviour
{
    public MainParamater mainParamater;
    public double fixedCashAmount;

    public void OnClick()
    {
        mainParamater.AddFixedCashAmount(fixedCashAmount);
    }
}


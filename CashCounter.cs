using UnityEngine;
using TMPro;

public class CashCounter : MonoBehaviour
{
    public TMP_Text cashCounterText;
    public MainParamater mainParamater;

    void Start()
    {
        cashCounterText.text = " ";
    }

    void Update()
    {
        double cashPerSecond = mainParamater.GetCashPerSecond();
        double currentCash = mainParamater.GetCash();

        cashCounterText.text = " " + (cashPerSecond * currentCash).ToString("F2") + " ";
    }
}

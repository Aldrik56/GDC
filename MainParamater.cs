using System.Collections;
using UnityEngine;
using TMPro;

public class MainParamater : MonoBehaviour
{
    public TextMeshProUGUI TotalCashText;
    public double Cash;
    public double CashPerSecond;
    private float ElapsedTime;
    private bool GenerateCashEnabled;
    public double totalCashGenerated;
    private bool spriteAdded = false;

    void Start()
    {
        Cash = 0;
        GenerateCashEnabled = false;
        totalCashGenerated = 50;
    }

    void Update()
    {
        if (spriteAdded)
        {
            ElapsedTime += Time.deltaTime;

            if (TotalCashText != null)
            {
                TotalCashText.text = " " + totalCashGenerated.ToString("F2");
            }

            if (ElapsedTime >= 1.0f && GenerateCashEnabled && spriteAdded)
            {
                Cash += CashPerSecond;
                ElapsedTime = 0.0f;
                totalCashGenerated += CashPerSecond;
            }
        }
    }

    public void SetSpriteAdded(double fixedCashAmount, double cashPerSecond)
    {
        if (!spriteAdded)
        {
            spriteAdded = true;
            GenerateCashEnabled = true;
            CashPerSecond = cashPerSecond;
            StartCoroutine(AddFixedCash(fixedCashAmount));
        }
    }

    public void UpgradeCashPerSecond(double upgradeAmount)
    {
        CashPerSecond += upgradeAmount;
    }

    public double GetCash()
    {
        return Cash;
    }

    public double GetCashPerSecond()
    {
        return CashPerSecond;
    }

    public IEnumerator AddFixedCash(double fixedCashAmount)
    {
        while (GenerateCashEnabled)
        {
            yield return new WaitForSeconds(1.0f);
            Cash += fixedCashAmount;
            totalCashGenerated += fixedCashAmount;
        }
    }

    public void AddFixedCashAmount(double amount)
    {
        Cash += amount;
        totalCashGenerated += amount;
    }
    public void reduceMoney(double money){
        Cash -=money;
    }
}


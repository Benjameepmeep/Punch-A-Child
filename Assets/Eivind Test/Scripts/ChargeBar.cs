using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeBar : MonoBehaviour
{
    public Slider chargeBar;

    private int maxCharge = 100;
    private int minCharge = 0;
    private int currentCharge;

    private WaitForSeconds chargeTick = new WaitForSeconds(0.02f);

    public static ChargeBar instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        currentCharge = minCharge;
        chargeBar.maxValue = maxCharge;
        chargeBar.value = minCharge;
    }


   private void Update()
   {
       if (currentCharge >= maxCharge)
       {
           print("Decrease");
           StopCoroutine(ChargeIncrease());
           StartCoroutine(ChargeDecrease());
       }

       if (currentCharge <= minCharge)
       {
           print("Increase");
           StopCoroutine(ChargeDecrease());
           StartCoroutine(ChargeIncrease());
       }
   }

   private IEnumerator ChargeDecrease()
   {
       yield return new WaitForSeconds(0.01f);
       while (currentCharge > minCharge)
       {
            currentCharge -= maxCharge / 100;
            chargeBar.value = currentCharge;
            yield return chargeTick;
       }
   }
   
   private IEnumerator ChargeIncrease()
   {
       yield return new WaitForSeconds(0.01f);
       while (currentCharge < maxCharge)
       {
           currentCharge += maxCharge / 100;
           chargeBar.value = currentCharge;
           yield return chargeTick;
       }
   }
}

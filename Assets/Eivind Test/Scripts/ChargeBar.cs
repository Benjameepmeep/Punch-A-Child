using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;

public class ChargeBar : MonoBehaviour
{
    public Slider chargeBar;

    private int _maxCharge = 100;
    private int _minCharge = 0;
    private int _currentCharge = 0;

    private WaitForSeconds _chargeTick = new WaitForSeconds(0.02f);

    public static ChargeBar instance;
    
    private bool _forceBarLockedIn = false;
    private bool _angleBarSpawned = false;
    private bool _angleBarLockedIn = false;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        StartCoroutine(ChargeIncrease());
        _currentCharge = _minCharge;
        chargeBar.maxValue = _maxCharge;
        chargeBar.value = _minCharge;
    }


   private void Update()
   {
       if (isActiveAndEnabled)
       {
           StopAllCoroutines();
           
       }
       
       if (_forceBarLockedIn && !_angleBarSpawned)
       {
           _angleBarSpawned = true;
       }
   }

   private IEnumerator ChargeDecrease()
   {
       StopCoroutine(ChargeIncrease());
       
       yield return new WaitForSeconds(0.01f);
       while (_currentCharge >= _minCharge)
       {
            _currentCharge -= _maxCharge / 100;
            chargeBar.value = _currentCharge;
            yield return _chargeTick;
       }
       if (_currentCharge >= _maxCharge)
       {
           StartCoroutine(ChargeIncrease());
       }
   }

   private IEnumerator ChargeIncrease()
   {
       StopCoroutine(ChargeDecrease());
       
       yield return new WaitForSeconds(0.01f);
       while (_currentCharge <= _maxCharge)
       {
           _currentCharge += _maxCharge / 100;
           chargeBar.value = _currentCharge;
           yield return _chargeTick;
       }
       if (_currentCharge >= _maxCharge)
       {
           StartCoroutine(ChargeDecrease());
       }
   }

   private IEnumerator RetainValuesAndSendToTrajectoryScript()
   {
       while (!_forceBarLockedIn)
       {
           yield return null;
       }
   }
   
}

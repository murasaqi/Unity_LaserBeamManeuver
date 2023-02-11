// namespace PanTiltLaserTimeline
// {

using System;
using UnityEngine;
[Serializable]
public class LaserRapidFireProp:LaserPropElement
{
    [Header("--- Rapid Fire ---")]
    
    [SerializeField, Range(0, 1)] public float rapidFire = 0f;
    [SerializeField,Range(1,30)] public int rapidFireCount = 5;
    [SerializeField, Range(-10,10)] public float rapidFireSpeed = 1;
    [SerializeField, Range(0, 1)] public float rapidFireTimeOffset = 0f;
    [SerializeField, Range(0, 1)] public float rapidFireAttack = 0f;
    [SerializeField, Range(0, 1)] public float rapidFireHold = 0f;
    [SerializeField, Range(0, 1)] public float rapidFireRelease = 0f;
    [SerializeField, Range(0, 1)] public float rapidFireRandomness = 0f;


    public LaserRapidFireProp(bool allValuesZero = false)
    {
        if (allValuesZero)
        {
            InitializeBasicValues();
        }
        else
        {
            InitializeAllWithZero();       
        }
    }

    public LaserRapidFireProp(LaserRapidFireProp laserRapidFireProp)
    {
        rapidFire = laserRapidFireProp.rapidFire;
        rapidFireCount = laserRapidFireProp.rapidFireCount;
        rapidFireSpeed = laserRapidFireProp.rapidFireSpeed;
        rapidFireTimeOffset = laserRapidFireProp.rapidFireTimeOffset;
        rapidFireAttack = laserRapidFireProp.rapidFireAttack;
        rapidFireHold = laserRapidFireProp.rapidFireHold;
        rapidFireRelease = laserRapidFireProp.rapidFireRelease;
        rapidFireRandomness = laserRapidFireProp.rapidFireRandomness;
    }
    
    public static LaserRapidFireProp operator+ (LaserRapidFireProp a, LaserRapidFireProp b)
    {
        return new LaserRapidFireProp()
        {
            rapidFire = a.rapidFire + b.rapidFire,
            rapidFireCount = a.rapidFireCount + b.rapidFireCount,
            rapidFireSpeed = a.rapidFireSpeed + b.rapidFireSpeed,
            rapidFireTimeOffset = a.rapidFireTimeOffset + b.rapidFireTimeOffset,
            rapidFireAttack = a.rapidFireAttack + b.rapidFireAttack,
            rapidFireHold = a.rapidFireHold + b.rapidFireHold,
            rapidFireRelease = a.rapidFireRelease + b.rapidFireRelease,
            rapidFireRandomness = a.rapidFireRandomness + b.rapidFireRandomness,
        };
    }
    
    public static LaserRapidFireProp operator- (LaserRapidFireProp a, LaserRapidFireProp b)
    {
        return new LaserRapidFireProp()
        {
            rapidFire = a.rapidFire - b.rapidFire,
            rapidFireCount = a.rapidFireCount - b.rapidFireCount,
            rapidFireSpeed = a.rapidFireSpeed - b.rapidFireSpeed,
            rapidFireTimeOffset = a.rapidFireTimeOffset - b.rapidFireTimeOffset,
            rapidFireAttack = a.rapidFireAttack - b.rapidFireAttack,
            rapidFireHold = a.rapidFireHold - b.rapidFireHold,
            rapidFireRelease = a.rapidFireRelease - b.rapidFireRelease,
            rapidFireRandomness = a.rapidFireRandomness - b.rapidFireRandomness,
        };
    }
    
    public static LaserRapidFireProp operator *(LaserRapidFireProp a, LaserRapidFireProp b)
    {
        return new LaserRapidFireProp()
        {
            rapidFire = a.rapidFire * b.rapidFire,
            rapidFireCount = a.rapidFireCount * b.rapidFireCount,
            rapidFireSpeed = a.rapidFireSpeed * b.rapidFireSpeed,
            rapidFireTimeOffset = a.rapidFireTimeOffset * b.rapidFireTimeOffset,
            rapidFireAttack = a.rapidFireAttack * b.rapidFireAttack,
            rapidFireHold = a.rapidFireHold * b.rapidFireHold,
            rapidFireRelease = a.rapidFireRelease * b.rapidFireRelease,
            rapidFireRandomness = a.rapidFireRandomness * b.rapidFireRandomness,
        };
    }
    
    public static LaserRapidFireProp operator *(LaserRapidFireProp a, float b)
    {
        return new LaserRapidFireProp()
        {
            rapidFire = a.rapidFire * b,
            rapidFireCount = a.rapidFireCount * (int)b,
            rapidFireSpeed = a.rapidFireSpeed * b,
            rapidFireTimeOffset = a.rapidFireTimeOffset * b,
            rapidFireAttack = a.rapidFireAttack * b,
            rapidFireHold = a.rapidFireHold * b,
            rapidFireRelease = a.rapidFireRelease * b,
            rapidFireRandomness = a.rapidFireRandomness * b,
        };
    }

    public override void InitializeAllWithZero()
    {
        base.InitializeAllWithZero();
        rapidFire = 0f;
        rapidFireCount = 0;
        rapidFireSpeed = 0;
        rapidFireTimeOffset = 0f;
        rapidFireAttack = 0f;
        rapidFireHold = 0f;
        rapidFireRelease = 0f;
        rapidFireRandomness = 0f;

    }
    
    public override void InitializeBasicValues()
    {
        base.InitializeBasicValues();
        rapidFire = 0f;
        rapidFireCount = 5;
        rapidFireSpeed = 1;
        rapidFireTimeOffset = 0f;
        rapidFireAttack = 0f;
        rapidFireHold = 0f;
        rapidFireRelease = 0f;
        rapidFireRandomness = 0f;
    }
}


// }
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class LaserLineFanBehaviour : PlayableBehaviour
{

    // public Vector2 v;
    [SerializeField]public LaserTransform laserTransform = new LaserTransform();
    [SerializeField]public LaserBasicProps laserBasicProps = new LaserBasicProps();
    [SerializeField]public LaserFanProps laserFanProps = new LaserFanProps();
    // [SerializeField]public LaserLineArrayProps laserLineArrayProps = new LaserLineArrayProps();
    [SerializeField]public LaserRapidFireProp laserRapidFireProp = new LaserRapidFireProp();
    [SerializeField]public override void OnPlayableCreate (Playable playable)
    {

        // SetBasicValues();
        // laserLineArrayProps
    }

    public void SetBasicValues()
    {
        laserBasicProps.InitializeBasicValues();
        laserFanProps.InitializeBasicValues();
        // laserLineArrayProps.InitializeBasicValues();
        laserRapidFireProp.InitializeBasicValues();
        laserTransform.SetBasicValues();
        
    }
}

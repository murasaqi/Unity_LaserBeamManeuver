using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class LaserLineFanMixerBehaviour : PlayableBehaviour
{
    
    private PlayableDirector _director;
    public PlayableDirector director
    {
        get { return _director; }
        set { _director = value; }
    }
    
   
    // NOTE: This function is called at runtime and edit time.  Keep that in mind when setting the values of properties.
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        StylizedLaser trackBinding = playerData as StylizedLaser;

        if (!trackBinding)
            return;

        trackBinding.laserType = LaserType.LineFan;
        int inputCount = playable.GetInputCount ();

        LaserBasicProps laserBasicProps = new LaserBasicProps();
        LaserLineArrayProps laserLineArrayProps = new LaserLineArrayProps();
        LaserTransform laserTransform = new LaserTransform();
        LaserRapidFireProp laserRapidFireProp = new LaserRapidFireProp();
        LaserFanProps laserFanProps = new LaserFanProps();
        laserBasicProps.InitializeAllWithZero();
        // laserLineArrayProps.InitializeAllWithZero();
        laserRapidFireProp.InitializeAllWithZero();
        laserFanProps.InitializeAllWithZero();
        laserTransform.InitEmptyValues();
        var currentInputs = new List<LaserLineFanBehaviour>();
        for (int i = 0; i < inputCount; i++)
        {
            float inputWeight = playable.GetInputWeight(i);
            ScriptPlayable<LaserLineFanBehaviour> inputPlayable = (ScriptPlayable<LaserLineFanBehaviour>)playable.GetInput(i);
            LaserLineFanBehaviour input = inputPlayable.GetBehaviour ();


          
            if (inputWeight > 0.0f)
            {
                // Debug.Log(i);
                laserBasicProps += input.laserBasicProps * inputWeight;
                // laserLineArrayProps += input.laserLineArrayProps * inputWeight;
                laserTransform += input.laserTransform * inputWeight;
                laserRapidFireProp += input.laserRapidFireProp * inputWeight;
                laserFanProps += input.laserFanProps * inputWeight;
                currentInputs.Add(input);
                // hasClip = true;
            }
            
           
            // trackBinding.SetLineArrayProps(laserLineArrayProps);
            // Use the above variables to process each frame of this playable.
            
        }

        // if (currentInputs.Count == 2)
        // {
        //     if (currentInputs.First().laserLineArrayProps.arrayCount ==
        //         currentInputs.Last().laserLineArrayProps.arrayCount)
        //     {
        //         laserLineArrayProps.arrayCount = currentInputs.First().laserLineArrayProps.arrayCount;
        //     }
        // }
        laserBasicProps.useManualTime = true;
        laserBasicProps.manualTime = (float)director.time;
        trackBinding.SetLaserTransform(laserTransform);
        trackBinding.SetBasicProps(laserBasicProps);
        trackBinding.SetRapidFirePros(laserRapidFireProp);
        trackBinding.SetLineArrayProps(laserLineArrayProps);
        trackBinding.SetFanProps(laserFanProps);
           
    }
}

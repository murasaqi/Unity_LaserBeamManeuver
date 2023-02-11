using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class LaserLineFanClip : PlayableAsset, ITimelineClipAsset
{
    public LaserLineFanBehaviour template = new LaserLineFanBehaviour ();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.Looping | ClipCaps.Blending | ClipCaps.Extrapolation; }
    }

    public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<LaserLineFanBehaviour>.Create (graph, template);
        LaserLineFanBehaviour clone = playable.GetBehaviour ();
        // template.SetBasicValues();
        return playable;
    }
}

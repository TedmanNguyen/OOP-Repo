using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : BallMovement
{

    public override void StandardBouncy()
    {

        bouncy.material.bounciness = .1f;
        
    }


}

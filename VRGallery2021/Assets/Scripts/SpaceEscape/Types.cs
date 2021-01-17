using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace InteractableTypes
{
    public enum State
    {
        inactive = 0,
        active = 1,
        selected = 2,
        activated = 3,
        grabbed = 4,
    }
}


// public enum MoveState
// {
//     Idle,
//     Run,
//     Jump,
//     Stunned,
//     Dash,
//     Crouch,
//     Fall,
// }
//
// public enum ActionState
// {
//     Idle,
//     Attack,
// }
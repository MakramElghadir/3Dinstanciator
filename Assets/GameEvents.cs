using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEvents
{
    public static UnityEvent<int, int> NewTimeValues = new UnityEvent<int, int>();
}

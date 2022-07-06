using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState 
{
    void OnEnter();
    void Tick();
    void OnExit();

    //TO DO: Consider adding FixedTick() and LateTick(), and change the current Tick() to UpdateTick()
}

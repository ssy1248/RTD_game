using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//터렛의 보너스
public enum TurretBonusType { Damage, Range, ShootCoolDown};

//누구에게 줄것인지
public enum BonusTarget { Self, Enemy};

public class TurretBonus : MonoBehaviour
{
    //보너스를 받아야 하는 타워의 갯수?
    public int TurretCnt = 0;

    public TurretBonusType turretBonus;

    public BonusTarget bonusTarget;
}

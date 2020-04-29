using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director
{
    private MonsterBuilder monsterBuilder;
    
    public void CreateMonster(MonsterBuilder monsterBuilder)
    {
        monsterBuilder.BuildBody();
        monsterBuilder.BuildHead();
        monsterBuilder.BuildLegs();
    }
}

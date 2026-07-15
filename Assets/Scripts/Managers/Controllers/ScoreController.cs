using UnityEngine;

[RequireComponent(typeof(GameManager))]
public class ScoreController : ScoreHandler
{
    protected override void Score(PaddleType type)
    {
        base.Score(type);


    }
}
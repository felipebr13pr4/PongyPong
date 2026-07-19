using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody2D))]
public class BallMovement : MonoBehaviour
{
    [SerializeField] private int m_initialSpeed = 2;
    private int m_speed;
    private Rigidbody2D m_rigidBody2d;
    private Vector2 m_direction = new(0, 0);
    public Vector2 P_Direction => m_direction;
    public int P_Speed => m_speed;

    private void Start()
    {
        m_rigidBody2d = GetComponent<Rigidbody2D>();

        StartCoroutine(RandomStartDirection());
    }

    private void FixedUpdate()
    {
        ScreenWallBounce();
        m_rigidBody2d.linearVelocity =
            m_direction.normalized * m_speed;
    }

    private void OnTriggerEnter2D()
    {
        m_direction.x = -m_direction.x;
        m_speed += 1;
        GameManager.Instance.P_AudioController.PlayAudio(AudioType.PaddleHit);
    }

    private void ScreenWallBounce()
    {
        float maxTopInScreen = 5.1f;
        float maxBottomInScreen = -5.1f;

        if (transform.position.y >= maxTopInScreen) {
            m_direction.y = -1;
            GameManager.Instance.P_AudioController.PlayAudio(AudioType.PaddleHit); 
        }
        if (transform.position.y <= maxBottomInScreen) {
            m_direction.y = 1;
            GameManager.Instance.P_AudioController.PlayAudio(AudioType.PaddleHit); }
    }

    public IEnumerator RandomStartDirection()
    {
        m_speed = 0;

        yield return new WaitForSeconds(0.2f);

        m_speed = m_initialSpeed;

        m_direction.x = 0;
        m_direction.y = 0;

        while (m_direction.y == 0)
        {
            m_direction.y = Random.Range(-1, 2);
        }
        while (m_direction.x == 0)
        {
            m_direction.x = Random.Range(-1, 2);
        }
    }
}

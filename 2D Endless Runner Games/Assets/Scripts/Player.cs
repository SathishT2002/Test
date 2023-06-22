using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runner.Player
{
    public class Player : MonoBehaviour
    {
        public float playerspeed;
        private Rigidbody2D rb;
        private Vector2 playerDirection;
        private float moveSpeed;
        public float moveUpDown ;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            float directionY = Input.GetAxisRaw("Vertical");
            playerDirection = new Vector2(0, directionY).normalized;
        }

        public void StopMoving()
        {
            rb.velocity = Vector2.zero;
        }

        void FixedUpdate()
        {
            rb.velocity = new Vector2(0, playerDirection.y * playerspeed);
        }

        public void MoveUp()
        {
            this.transform.Translate(new Vector2(0f, 80f) * Time.deltaTime, Space.World);
        }

        public void MoveDown()
        {
            this.transform.Translate(new Vector2(0f, -80f) * Time.deltaTime, Space.World);
        }
    }
}
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitboxesAndHurtboxes
{
    public enum PlayerState
    {
        Idle,
        Rock,
        Paper,
        Scissors,
        TakeDamage
    }
    internal class Player
    {
        /// <summary>
        /// gets or sets idle animation
        /// </summary>
        public Animation Idle { get; private set; }

        /// <summary>
        /// gets or sets rock animation
        /// </summary>
        public Animation Rock { get; private set; }

        /// <summary>
        /// gets or sets paper animation
        /// </summary>
        public Animation Paper { get; private set; }

        /// <summary>
        /// gets or sets scissors animation
        /// </summary>
        public Animation Scissors { get; private set; }

        /// <summary>
        /// gets or sets color of player's animations
        /// </summary>
        public Color Color { get; private set; }

        /// <summary>
        /// gets or sets state of player
        /// </summary>
        public PlayerState State { get; set; }

        /// <summary>
        /// position of player
        /// </summary>
        public Vector2 Position { get; set; }

        /// <summary>
        /// sprite effects on player
        /// </summary>
        public SpriteEffects Effects { get; set; }

        /// <summary>
        /// current animation player obj is displaying
        /// </summary>
        private Animation currentAnimation { get; set; }

        /// <summary>
        /// gets or sets health of player obj
        ///
        /// </summary>
        int Health { get; set; }

        /// <summary>
        /// instantiates a player object with every
        /// field specified
        /// </summary>
        /// <param name="idle">idle animation</param>
        /// <param name="rock">rock animation</param>
        /// <param name="paper">paper animation</param>
        /// <param name="scissors">scissors animation</param>
        /// <param name="color">color</param>
        /// <param name="state">current state</param>
        /// <param name="position">position of player</param>
        /// <param name="effects">effects on obj</param>
        /// <param name="health">health of obk</param>
        public Player(Animation idle, Animation rock, Animation paper, Animation scissors, Color color, PlayerState state, Vector2 position, SpriteEffects effects, int health)
        {
            Idle = idle;
            Rock = rock;
            Paper = paper;
            Scissors = scissors;
            Color = color;
            State = state;
            Position = position;
            Effects = effects;
            Health = health;
        }

        /// <summary>
        /// instantiates a player obj with a default value for health
        /// </summary>
        /// <param name="idle">idle anim</param>
        /// <param name="rock">rock anim</param>
        /// <param name="paper">paper anim</param>
        /// <param name="scissors">scissors anim</param>
        /// <param name="color">color</param>
        /// <param name="state">state</param>
        /// <param name="position">position</param>
        /// <param name="effects">sprite effects</param>
        public Player(Animation idle, Animation rock, Animation paper, Animation scissors, Color color, PlayerState state, Vector2 position, SpriteEffects effects)
        : this(idle, rock, paper, scissors, color, state, position, effects, 5) { }

        /// <summary>
        /// overload with default values for PlayerState SpriteEffects, and health
        /// </summary>
        /// <param name="idle">idle animation</param>
        /// <param name="rock">rock animation</param>
        /// <param name="paper">paper animation</param>
        /// <param name="scissors">scissors animation</param>
        /// <param name="color">color of player</param>
        /// <param name="position">position of player</param>
        public Player(Animation idle, Animation rock, Animation paper, Animation scissors, Color color, Vector2 position) 
        :this(idle, rock, paper, scissors, color, PlayerState.Idle, position, SpriteEffects.None, 5){ }

        /// <summary>
        /// updates the current animation
        /// </summary>
        /// <param name="gameTime">gameTime</param>
        /// <param name="currentState">current state of player obj</param>
        public void Update(GameTime gameTime, PlayerState currentState)
        {
            if (currentState != State)
            {
                currentAnimation.CurrentFrame = 0;
                State = currentState;

                switch (State)
                {
                    case PlayerState.Idle:
                        currentAnimation = Idle;
                        break;

                    case PlayerState.Rock:
                        currentAnimation = Rock;
                        break;

                    case PlayerState.Paper:
                        currentAnimation = Paper;
                        break;

                    case PlayerState.Scissors:
                        currentAnimation = Scissors;
                        break;

                    case PlayerState.TakeDamage:
                        currentAnimation = TakeDamage;
                        break;
                }
            }

            currentAnimation.UpdateAnimation(gameTime);
        }

        /// <summary>
        /// draws the player object
        /// </summary>
        /// <param name="sb">spritebatch</param>
        public void Draw(SpriteBatch sb, GameTime gameTime)
        {
            currentAnimation.Draw(sb, gameTime, Position, Color, Effects);
        }
    }
}

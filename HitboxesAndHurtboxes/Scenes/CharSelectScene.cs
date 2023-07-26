using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HitboxesAndHurtboxes.CoreFiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using HitboxesAndHurtboxes.Managers;

//Character select scene
//displays changes for both player one and two side
namespace HitboxesAndHurtboxes.Scenes
{
    internal class CharSelectScene : Component
    {
        public Input userInput;

        public static Color[] characterClrs = { Color.White, Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Orange, Color.Pink, Color.Purple, Color.Brown };
        public int playerOneClr;
        public int playerTwoClr;

        private Texture2D charSelectText;
        private Texture2D arrowButtonText;
        private Texture2D startText;

        private Animation playerOneSelect;
        private Animation playerTwoSelect;

        private Button playerOneLeft;
        private Button playerOneRight;

        private Button playerTwoLeft;
        private Button playerTwoRight;

        private Button startButton;

        private Button[] buttons;
        public override void Initialize(ContentManager content)
        {
            userInput = new Input();

            playerOneClr = 0;
            playerTwoClr = 0;
            charSelectText = content.Load<Texture2D>("RPS_CharSelect");
            arrowButtonText = content.Load<Texture2D>("Arrow");
            startText = content.Load<Texture2D>("button0");

            playerOneSelect = new Animation(charSelectText, 6, 1, 6);
            playerTwoSelect = new Animation(charSelectText, 6, 1, 6);
            playerOneSelect.Position = new Vector2(Data.ScreenWidth / 4, Data.ScreenHeight / 2);
            playerTwoSelect.Position = new Vector2(Data.ScreenWidth - (Data.ScreenWidth / 4), Data.ScreenHeight / 2);

            playerOneLeft = new Button(arrowButtonText, new Rectangle((int)(playerOneSelect.Position.X - 50), (int)playerOneSelect.Position.Y, arrowButtonText.Width / 4, arrowButtonText.Height / 4), SpriteEffects.FlipHorizontally);
            playerOneRight = new Button(arrowButtonText, new Rectangle((int)(playerOneSelect.Position.X + playerOneSelect.SourceRectangle.Width + 100), (int)playerOneSelect.Position.Y, arrowButtonText.Width / 4, arrowButtonText.Height / 4));

            playerTwoLeft = new Button(arrowButtonText, new Rectangle((int)(playerTwoSelect.Position.X - 50), (int)playerTwoSelect.Position.Y, arrowButtonText.Width / 4, arrowButtonText.Height / 4), SpriteEffects.FlipHorizontally);
            playerTwoRight = new Button(arrowButtonText, new Rectangle((int)(playerTwoSelect.Position.X + playerTwoSelect.SourceRectangle.Width + 100), (int)playerTwoSelect.Position.Y, arrowButtonText.Width / 4, arrowButtonText.Height / 4));

            startButton = new Button(startText, new Rectangle((Data.ScreenWidth - startText.Width) / MenuScene.scalingFactor / 2, (Data.ScreenHeight - startText.Height) / MenuScene.scalingFactor / 2, startText.Width / MenuScene.scalingFactor, startText.Height / MenuScene.scalingFactor));

            buttons = new Button[5];
            buttons[0] = playerOneLeft;
            buttons[1] = playerOneRight;
            buttons[2] = playerTwoLeft;
            buttons[3] = playerTwoRight;
            buttons[4] = startButton;
        }

        public override void Update(GameTime gameTime)
        {
            userInput.UpdateMouse(gameTime);

            foreach (Button button in buttons)
            {
                button.Update(userInput.mousePos);
            }

            if (playerOneLeft.ButtonColor == Color.Gray && userInput.LeftButtonReleased())
            {
                playerOneClr -= 1;
                if (playerOneClr < 0)
                {
                    playerOneClr = characterClrs.Length - 1;
                }
                playerOneSelect.Color = characterClrs[playerOneClr];
            }

            else if (playerTwoLeft.ButtonColor == Color.Gray && userInput.LeftButtonReleased())
            {
                playerTwoClr -= 1;
                if (playerTwoClr < 0)
                {
                    playerTwoClr = characterClrs.Length - 1;
                }

                playerTwoSelect.Color = characterClrs[playerTwoClr];
            }

            else if (playerOneRight.ButtonColor == Color.Gray && userInput.LeftButtonReleased())
            {
                playerOneClr += 1;
                if (playerOneClr == characterClrs.Length)
                {
                    playerOneClr = 0;

                    playerOneSelect.Color = characterClrs[playerOneClr];
                }

            }

            else if (playerTwoRight.ButtonColor == Color.Gray && userInput.LeftButtonReleased())
            {
                playerTwoClr += 1;
                if (playerTwoClr == characterClrs.Length)
                {
                    playerTwoClr = 0;
                }
                playerTwoSelect.Color = characterClrs[playerTwoClr];
            }

            else if (startButton.ButtonColor == Color.Gray && userInput.LeftButtonReleased())

            playerOneSelect.UpdateAnimation(gameTime);
            playerTwoSelect.UpdateAnimation(gameTime);
        }

        public override void Draw(SpriteBatch sb, GameTime gameTime)
        {
            foreach (Button button in buttons)
            {
                button.Draw(sb);
            }

            playerOneSelect.Draw(sb, gameTime);
            playerTwoSelect.Draw(sb, gameTime);
        }
    }
}

using System;
using DefaultEcs;
using DefaultEcs.System;
using DefaultEcs.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

using GameTemplate.Components;
using GameTemplate.Engine.Systems;

namespace GameTemplate {
    public class Main : Game {
        World _world;
        Entity _tmpPlayer;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        ISystem<float> _drawSystem;

        public Main() {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            // Init ECS World
            _world = new World();
        }

        protected override void Initialize() {
            // Create new entity
            _tmpPlayer = _world.CreateEntity();
            base.Initialize();
        }

        protected override void LoadContent() {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            _drawSystem = new DrawSystem(spriteBatch, _world, new DefaultParallelRunner(Environment.ProcessorCount));

            _tmpPlayer.Set(new CDraw {
                Texture = this.Content.Load<Texture2D>("Sprites/box"),
                Destination = new Vector2(50, 50),
                Color = Color.White
            });
        }

        protected override void Update(GameTime gameTime) {
            // TODO: Allow exit only through menus
            if (Keyboard.GetState().IsKeyDown(Keys.Escape)) { Exit(); }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _drawSystem.Update((float)gameTime.ElapsedGameTime.TotalSeconds);
            base.Draw(gameTime);
        }
    }
}
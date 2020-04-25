using System;
using DefaultEcs;
using DefaultEcs.System;
using DefaultEcs.Threading;
using Microsoft.Xna.Framework.Graphics;

using GameTemplate.Components;
namespace GameTemplate.Engine.Systems {
    public class DrawSystem : AComponentSystem<float, CDraw> {
        private readonly SpriteBatch _batch;
        private readonly World _world;
        private readonly IParallelRunner _runner;

        public DrawSystem(SpriteBatch batch, World world, IParallelRunner runner) : base(world) {
            _batch = batch;
            _world = world;
            _runner = runner;
        }

        protected override void PreUpdate(float state) => _batch.Begin(samplerState: SamplerState.PointClamp);

        protected virtual void Draw(float state) {
            Update(state);
        }

        protected override void Update(float state, Span<CDraw> components) {
            foreach (ref CDraw component in components) {
                _batch.Draw(component.Texture, component.Destination, component.Color);
            }
        }

        protected override void PostUpdate(float state) => _world.Optimize(_runner, _batch.End);
    }
}
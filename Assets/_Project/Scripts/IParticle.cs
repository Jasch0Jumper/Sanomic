using UnityEngine;

namespace Terra
{
    public interface IParticle
    {
        public ParticleData Data { get; }
        
        public Vector Position { get; set; }
        public Vector Velocity { get; set; }
    }
}